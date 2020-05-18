using CronNET.Impl;
using DevExpress.XtraGrid.Views.Grid;
using EASendMail;
using PrinterTonerCheck.Forms;
using PrinterTonerCheck.Helpers;
using PrinterTonerCheck.Model.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrinterTonerCheck
{
    public partial class frmMain : Form
    {
        DbHelper context = Globals.context;
        public frmMain()
        {
            InitializeComponent();
            context.Database.CreateIfNotExists();
            Globals.LoadJob();
        }        

        private void BtnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.ShowDialog();
        }

        private static readonly CronDaemon cron_daemon = new CronDaemon();
        private void BarBtnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Globals.nJob == null)
            {
                MessageBox.Show("Job Ayarlarını Yapınız.");
                return;
            }

            CheckForIllegalCrossThreadCalls = false;
            barlblStatus.Caption = "Job Çalıştırıldı.";
            barBtnStart.Enabled = false;
            barBtnStop.Enabled = true;

            Task.Factory.StartNew(()=> {
                Globals.GetTonerStatus(false);
                Globals.LoadPrinters(gridControl);
                Console.WriteLine("İlk Kontrol Çalıştı.");
            }).ContinueWith(delegate {
                string _schedule = null;

                switch (Globals.nJob.JobTipi)
                {
                    case JobType.Gunluk:
                        {
                            _schedule = "30	7 *	* 1,2,3,4,5,6";
                            break;
                        }
                    case JobType.Haftalik:
                        {
                            _schedule = "30 7 * * 1";
                            break;
                        }
                    case JobType.Saatlik:
                        {
                            _schedule = "0 * * * *";
                            break;
                        }
                    default:
                        _schedule = "*/5 * * * *";
                        break;
                }

                cron_daemon.Add(new CronJob(() =>
                {
                    Globals.GetTonerStatus(false);
                    Globals.LoadPrinters(gridControl);
                    Console.WriteLine("Job Çalıştı.");
                    return Task.CompletedTask;
                }, null, _schedule));

                cron_daemon.Add(new CronJob(() =>
                {
                    Globals.GetTonerStatus(true);
                    Globals.LoadPrinters(gridControl);
                    Console.WriteLine("Günlük Kontrol Çalıştı.");
                    return Task.CompletedTask;
                }, null, "30 10 * * 1,2,3,4,5,6"));

                cron_daemon.Start(CancellationToken.None);
            });
        }

        private void GridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if(e.Column.Name == "colCLevel" 
                || e.Column.Name == "colMLevel"
                || e.Column.Name == "colYLevel"
                || e.Column.Name == "colKLevel")
            {
                if(Convert.ToInt32(e.CellValue) <= Globals.nJob.Min)
                {
                    e.Appearance.ForeColor = Color.Red;
                }else if(Convert.ToInt32(e.CellValue) > 10 & Convert.ToInt32(e.CellValue) <= 70)
                {
                    e.Appearance.ForeColor = Color.Orange;
                }
                else if (Convert.ToInt32(e.CellValue) > 70)
                {
                    e.Appearance.ForeColor = Color.Green;
                }
            }
        }

        private void BarBtnStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cron_daemon.Stop();
            barlblStatus.Caption = "Job Durduruldu.";
            barBtnStart.Enabled = true;
            barBtnStop.Enabled = false;
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Globals.LoadPrinters(gridControl);
        }

        private void BtnCheckManuel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backWorker.RunWorkerAsync();         
        }

        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BarBtnConsole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Globals.PageConsole = new frmConsole();
            Globals.PageConsole.Show();
        }

        private void BackWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (Globals.PageConsole != null)
            {
                Invoke(new Action(() =>
                {

                    Globals.PageConsole.txtConsole.Text += "Manual Kontrol Başladı" + Environment.NewLine;
                }));
            }
            
            LogManager.MyLogger().Debug("Manual Kontrol Başladı");
            Globals.GetTonerStatus(true);            
        }

        private void BackWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (Globals.PageConsole != null)
            {
                Invoke(new Action(() =>
                {
                    Globals.PageConsole.txtConsole.Text += "Manual Kontrol Bitti" + Environment.NewLine;
                }));
            }
            Globals.LoadPrinters(gridControl);
            LogManager.MyLogger().Debug("Manual Kontrol Bitti");
        }

        private void FrmMain_LocationChanged(object sender, EventArgs e)
        {
        }
    }
}
