using PrinterTonerCheck.Helpers;
using System;
using System.Windows.Forms;

namespace PrinterTonerCheck.Forms
{
    public partial class frmConsole : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmConsole()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnPin_Click(object sender, System.EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void FrmConsole_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
