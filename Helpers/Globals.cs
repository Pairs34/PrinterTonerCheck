using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using EASendMail;
using PrinterTonerCheck.Forms;
using PrinterTonerCheck.Model;
using PrinterTonerCheck.Model.Context;
using PrinterTonerCheck.Model.Entity;
using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PrinterTonerCheck.Helpers
{
    class Globals
    {
        public static string SETTING_PATH = $"{Application.StartupPath}\\settings.xml";
        public static Job nJob;
        public static DbHelper context = new DbHelper();
        public static frmConsole PageConsole;
        public static Job LoadJob()
        {
            if (File.Exists(SETTING_PATH))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(Job));
                FileStream myFileStream = new FileStream(SETTING_PATH, FileMode.Open);

                Job job = (Job)mySerializer.Deserialize(myFileStream);
                nJob = job;
            }
            return nJob;
        }

        public static void LoadPrinters(GridControl grid)
        {
            try
            {
                grid.DataSource = null;
                var printers = context.PrinterToners.ToList();
                grid.DataSource = printers;
                GridView view = grid.MainView as GridView;
                view.Columns["LastRun"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                view.Columns["NextRun"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                view.Columns["LastRun"].DisplayFormat.FormatString = "g";
                view.Columns["NextRun"].DisplayFormat.FormatString = "g";

                if (PageConsole != null)
                {
                    PageConsole.txtConsole.Invoke((MethodInvoker)delegate
                    {
                        PageConsole.txtConsole.Text += "Grid yüklendi" + Environment.NewLine;
                    });
                }
                LogManager.MyLogger().Debug("Grid yüklendi");
            }
            catch (Exception exc)
            {
                LogManager.MyLogger().Warn(exc);
            }
        }

        static void SendMail(List<Printer> Printers)
        {
            try
            {


                string messageBody = String.Empty;
                foreach (var item in Printers)
                {
                    var HtmlBody = File.ReadAllText($"{Application.StartupPath}\\HtmlBody.txt");

                    List<string> Tonerler = new List<string>();

                    if (item.MailNeed)
                    {
                        if (item.CLevel < nJob.Min)
                            if (!String.IsNullOrWhiteSpace(item.CName))
                                Tonerler.Add(item.CName + " %" + item.CLevel);
                        if (item.MLevel < nJob.Min)
                            if (!String.IsNullOrWhiteSpace(item.MName))
                                Tonerler.Add(item.MName + " %" + item.MLevel);
                        if (item.YLevel < nJob.Min)
                            if (!String.IsNullOrWhiteSpace(item.YName))
                                Tonerler.Add(item.YName + " %" + item.YLevel);
                        if (item.KLevel < nJob.Min)
                            if (!String.IsNullOrWhiteSpace(item.KName))
                                Tonerler.Add(item.KName + " %" + item.KLevel);
                    }
                    if (Tonerler.Count > 0)
                    {
                        var Toner = String.Join(", ", Tonerler.ToArray());
                        HtmlBody = HtmlBody.Replace("#toneradı#", Toner);
                        HtmlBody = HtmlBody.Replace("#printername#", item.Name);
                        HtmlBody = HtmlBody.Replace("#printermodel#", item.Model);
                        messageBody += HtmlBody + "\r\n";
                    }
                }

                if (!String.IsNullOrWhiteSpace(messageBody))
                {
                    SmtpMail mail = new SmtpMail("TryIt");
                    SmtpClient client = new SmtpClient();
                    mail.From = "aliyildirim@tktuzla.com";
                    mail.To = nJob.MailAdresi;
                    mail.Subject = "İhtiyacımız olan tonerler";
                    mail.HtmlBody = messageBody;
                    SmtpServer server = new SmtpServer("mail.tktuzla.com");

                    client.SendMail(server, mail);
                }
            }
            catch (Exception exc)
            {
                LogManager.MyLogger().Warn(exc);
            }
        }

        public static void GetTonerStatus(bool isManual)
        {
            try
            {

                OctetString community = new OctetString("public");
                AgentParameters param = new AgentParameters(community);
                context.Database.Initialize(false);
                var Printers = context.PrinterToners.ToList();//.Where(x=> x.Id == 16);

                foreach (var item in Printers)
                {
                    item.LastRun = DateTime.Now;

                    switch (nJob.JobTipi)
                    {
                        case JobType.Gunluk:
                            item.NextRun = DateTime.Now.AddDays(1);
                            break;
                        case JobType.Haftalik:
                            item.NextRun = DateTime.Now.AddDays(7);
                            break;
                        case JobType.Saatlik:
                            item.NextRun = DateTime.Now.AddHours(1);
                            break;
                        case JobType.HerDakika:
                            item.NextRun = DateTime.Now.AddMinutes(5);
                            break;
                        default:
                            break;
                    }
                }

                foreach (var item in Printers)
                {
                    Pdu pdu = new Pdu(PduType.Get);
                    IpAddress agent = new IpAddress(item.Ip);
                    switch (item.SnmpVersion)
                    {
                        case 1:
                            {
                                param.Version = SnmpVersion.Ver1;
                                break;
                            }
                        case 2:
                            {
                                param.Version = SnmpVersion.Ver2;
                                break;
                            }
                        case 3:
                            {
                                param.Version = SnmpVersion.Ver3;
                                break;
                            }
                        default:
                            break;
                    }
                    if (Globals.PingHost(item.Ip))
                    {
                        UdpTarget target = new UdpTarget((IPAddress)agent, 161, 3000, 2);
                        TonerDurum tDurum = new TonerDurum();

                        if (item.Tip == PrinterTip.KyoceraBlack)
                        {
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.8.1.1");//Total Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.1");//Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.1");//Black Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.25.3.2.1.3.1");//Printer Model
                            SnmpPacket result = target.Request(pdu, param);
                            if (result != null)
                            {
                                if (result.Pdu.ErrorStatus != 0)
                                {
                                    Console.WriteLine("Error in SNMP reply. Error {0} index {1}",
                                        result.Pdu.ErrorStatus,
                                        result.Pdu.ErrorIndex);
                                }
                                else
                                {
                                    int TotalPrintable = Convert.ToInt32(result.Pdu.VbList[0].Value.ToString());
                                    int NowPrintable = Convert.ToInt32(result.Pdu.VbList[1].Value.ToString());
                                    double Divid = (double)NowPrintable / TotalPrintable;
                                    tDurum.KLevel = Convert.ToInt32(Divid * 100);
                                    tDurum.KName = result.Pdu.VbList[2].Value.ToString();
                                }
                            }

                            item.KLevel = tDurum.KLevel;
                            item.KName = tDurum.KName;
                            item.Model = result.Pdu.VbList[3].Value.ToString();
                        }
                        else if (item.Tip == PrinterTip.KyoceraColor)
                        {
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.8.1.1");//C Total Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.8.1.2");//M Total Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.8.1.3");//Y Total Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.8.1.4");//K Total Printable

                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.1");//C Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.2");//M Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.3");//Y Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.4");//K Now Printable

                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.1");//C Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.2");//M Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.3");//Y Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.4");//K Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.25.3.2.1.3.1");//Printer Model

                            SnmpPacket result = target.Request(pdu, param);
                            if (result != null)
                            {
                                if (result.Pdu.ErrorStatus != 0)
                                {
                                    Console.WriteLine("Error in SNMP reply. Error {0} index {1}",
                                        result.Pdu.ErrorStatus,
                                        result.Pdu.ErrorIndex);
                                }
                                else
                                {
                                    int cTotalPrintable = Convert.ToInt32(result.Pdu.VbList[0].Value.ToString());
                                    int mTotalPrintable = Convert.ToInt32(result.Pdu.VbList[1].Value.ToString());
                                    int yTotalPrintable = Convert.ToInt32(result.Pdu.VbList[2].Value.ToString());
                                    int kTotalPrintable = Convert.ToInt32(result.Pdu.VbList[3].Value.ToString());

                                    int cNowPrintable = Convert.ToInt32(result.Pdu.VbList[4].Value.ToString());
                                    int mNowPrintable = Convert.ToInt32(result.Pdu.VbList[5].Value.ToString());
                                    int yNowPrintable = Convert.ToInt32(result.Pdu.VbList[6].Value.ToString());
                                    int kNowPrintable = Convert.ToInt32(result.Pdu.VbList[7].Value.ToString());

                                    double cPercent = (double)cNowPrintable / cTotalPrintable;
                                    double mPercent = (double)mNowPrintable / mTotalPrintable;
                                    double yPercent = (double)yNowPrintable / yTotalPrintable;
                                    double kPercent = (double)kNowPrintable / kTotalPrintable;

                                    tDurum.CLevel = Convert.ToInt32(cPercent * 100);
                                    tDurum.MLevel = Convert.ToInt32(mPercent * 100);
                                    tDurum.YLevel = Convert.ToInt32(yPercent * 100);
                                    tDurum.KLevel = Convert.ToInt32(kPercent * 100);

                                    tDurum.CName = result.Pdu.VbList[8].Value.ToString();
                                    tDurum.MName = result.Pdu.VbList[9].Value.ToString();
                                    tDurum.YName = result.Pdu.VbList[10].Value.ToString();
                                    tDurum.KName = result.Pdu.VbList[11].Value.ToString();

                                    item.CLevel = tDurum.CLevel;
                                    item.MLevel = tDurum.MLevel;
                                    item.YLevel = tDurum.YLevel;
                                    item.KLevel = tDurum.KLevel;

                                    item.CName = tDurum.CName;
                                    item.MName = tDurum.MName;
                                    item.YName = tDurum.YName;
                                    item.KName = tDurum.KName;
                                    item.Model = result.Pdu.VbList[12].Value.ToString();
                                }
                            }
                        }
                        else if (item.Tip == PrinterTip.HP)
                        {
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.2");//C Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.3");//M Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.4");//Y Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.1");//K Now Printable

                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.2");//C Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.3");//M Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.4");//Y Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.1");//K Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.25.3.2.1.3.1");//Printer Model
                            SnmpPacket result = target.Request(pdu, param);
                            if (result != null)
                            {
                                if (result.Pdu.ErrorStatus != 0)
                                {
                                    Console.WriteLine("Error in SNMP reply. Error {0} index {1}",
                                        result.Pdu.ErrorStatus,
                                        result.Pdu.ErrorIndex);
                                }
                                else
                                {
                                    int cNowPrintable = Convert.ToInt32(result.Pdu.VbList[0].Value.ToString());
                                    int mNowPrintable = Convert.ToInt32(result.Pdu.VbList[1].Value.ToString());
                                    int yNowPrintable = Convert.ToInt32(result.Pdu.VbList[2].Value.ToString());
                                    int kNowPrintable = Convert.ToInt32(result.Pdu.VbList[3].Value.ToString());

                                    tDurum.CLevel = cNowPrintable;
                                    tDurum.MLevel = mNowPrintable;
                                    tDurum.YLevel = yNowPrintable;
                                    tDurum.KLevel = kNowPrintable;

                                    tDurum.CName = result.Pdu.VbList[4].Value.ToString();
                                    tDurum.MName = result.Pdu.VbList[5].Value.ToString();
                                    tDurum.YName = result.Pdu.VbList[6].Value.ToString();
                                    tDurum.KName = result.Pdu.VbList[7].Value.ToString();

                                    item.CLevel = tDurum.CLevel;
                                    item.MLevel = tDurum.MLevel;
                                    item.YLevel = tDurum.YLevel;
                                    item.KLevel = tDurum.KLevel;

                                    item.CName = tDurum.CName;
                                    item.MName = tDurum.MName;
                                    item.YName = tDurum.YName;
                                    item.KName = tDurum.KName;
                                    item.Model = result.Pdu.VbList[8].Value.ToString();
                                }
                            }
                        }
                        else if (item.Tip == PrinterTip.Canon)
                        {
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.2");//C Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.3");//M Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.4");//Y Now Printable
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.9.1.1");//K Now Printable

                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.2");//C Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.3");//M Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.4");//Y Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.43.11.1.1.6.1.1");//K Toner Name
                            pdu.VbList.Add("1.3.6.1.2.1.25.3.2.1.3.1");//Printer Model
                            SnmpPacket result = target.Request(pdu, param);
                            if (result != null)
                            {
                                if (result.Pdu.ErrorStatus != 0)
                                {
                                    Console.WriteLine("Error in SNMP reply. Error {0} index {1}",
                                        result.Pdu.ErrorStatus,
                                        result.Pdu.ErrorIndex);
                                }
                                else
                                {
                                    int cNowPrintable = Convert.ToInt32(result.Pdu.VbList[0].Value.ToString());
                                    int mNowPrintable = Convert.ToInt32(result.Pdu.VbList[1].Value.ToString());
                                    int yNowPrintable = Convert.ToInt32(result.Pdu.VbList[2].Value.ToString());
                                    int kNowPrintable = Convert.ToInt32(result.Pdu.VbList[3].Value.ToString());

                                    tDurum.CLevel = cNowPrintable;
                                    tDurum.MLevel = mNowPrintable;
                                    tDurum.YLevel = yNowPrintable;
                                    tDurum.KLevel = kNowPrintable;

                                    tDurum.CName = result.Pdu.VbList[4].Value.ToString();
                                    tDurum.MName = result.Pdu.VbList[5].Value.ToString();
                                    tDurum.YName = result.Pdu.VbList[6].Value.ToString();
                                    tDurum.KName = result.Pdu.VbList[7].Value.ToString();

                                    item.CLevel = tDurum.CLevel;
                                    item.MLevel = tDurum.MLevel;
                                    item.YLevel = tDurum.YLevel;
                                    item.KLevel = tDurum.KLevel;

                                    item.CName = tDurum.CName;
                                    item.MName = tDurum.MName;
                                    item.YName = tDurum.YName;
                                    item.KName = tDurum.KName;
                                    item.Model = result.Pdu.VbList[8].Value.ToString();
                                }
                            }
                        }

                        context.SaveChanges();
                    }
                }

                if (PageConsole != null)
                {
                    PageConsole.txtConsole.Invoke((MethodInvoker)delegate
                    {
                        PageConsole.txtConsole.Text += "Veriler Toplandı" + Environment.NewLine;
                    });
                }
                if (isManual == false)
                    SendMail(Printers);

            }
            catch (Exception exc)
            {
                LogManager.MyLogger().Warn(exc);
            }
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
    }
}
