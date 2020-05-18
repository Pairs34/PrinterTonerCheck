using DevExpress.XtraEditors;
using PrinterTonerCheck.Helpers;
using PrinterTonerCheck.Model;
using PrinterTonerCheck.Model.Context;
using PrinterTonerCheck.Model.Entity;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PrinterTonerCheck.Forms
{
    public partial class frmSettings : XtraForm
    {
        DbHelper context = Globals.context;
        
        public frmSettings()
        {
            InitializeComponent();           
        }      

        void ClearForm()
        {
            txtPrinterIp.ResetText();
            txtPrinterName.ResetText();
            cbPrinterType.ResetText();
        }

        private async void BtnSavePrinter_Click(object sender, System.EventArgs e)
        {
            try
            {
                context.PrinterToners.Add(
                new Printer()
                {
                    Name = txtPrinterName.Text,
                    Ip = txtPrinterIp.Text,
                    Tip = (PrinterTip)Enum.Parse(typeof(PrinterTip), cbPrinterType.Text),
                    SnmpVersion = Convert.ToInt32(cbSnmpVersion.Text),
                    MailNeed = cbNeedMail.Checked
                });
                await context.SaveChangesAsync();

                MessageBox.Show("Kaydedildi.");

                ClearForm();

                Globals.LoadPrinters(gridControl);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void FrmSettings_Shown(object sender, EventArgs e)
        {
            Globals.LoadPrinters(gridControl);

            var job = Globals.LoadJob();
            if (job != null)
            {
                txtMail.Text = job.MailAdresi;
                cbJobType.Text = job.JobTipi.ToString();
                ckSendMail.Checked = job.OtoMail;
                txtMin.Text = job.Min.ToString();
            }
        }

        private void GridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupMenu.ShowPopup(Cursor.Position);
        }

        private async void BarBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var selectedRow = gridView.GetFocusedRow() as Printer;
                context.PrinterToners.Remove(selectedRow);
                await context.SaveChangesAsync();

                Globals.LoadPrinters(gridControl);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            
        }

        private async void BtnSavePrinterList_Click(object sender, EventArgs e)
        {
            try
            {
                gridView.PostEditor();
                await context.SaveChangesAsync();

                Globals.LoadPrinters(gridControl);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }     
        }

        private void BtnSaveJob_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            job.JobTipi = (JobType)Enum.Parse(typeof(JobType), cbJobType.Text);
            job.MailAdresi = txtMail.Text;
            job.OtoMail = ckSendMail.Checked;
            job.Min = Convert.ToInt32(txtMin.Text);

            XmlSerializer mySerializer = new XmlSerializer(typeof(Job));
            StreamWriter myWriter = new StreamWriter(Globals.SETTING_PATH);
            mySerializer.Serialize(myWriter, job);
            myWriter.Close();
            

            Globals.LoadJob();
        }
    }
}
