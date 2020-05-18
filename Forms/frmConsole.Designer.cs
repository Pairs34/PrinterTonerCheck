namespace PrinterTonerCheck.Forms
{
    partial class frmConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsole));
            this.txtConsole = new DevExpress.XtraEditors.MemoEdit();
            this.btnPin = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsole.Location = new System.Drawing.Point(10, 30);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtConsole.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtConsole.Properties.Appearance.Options.UseBackColor = true;
            this.txtConsole.Properties.Appearance.Options.UseFont = true;
            this.txtConsole.Properties.Appearance.Options.UseForeColor = true;
            this.txtConsole.Size = new System.Drawing.Size(564, 208);
            this.txtConsole.TabIndex = 0;
            // 
            // btnPin
            // 
            this.btnPin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPin.Location = new System.Drawing.Point(522, 3);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(23, 23);
            this.btnPin.TabIndex = 1;
            this.btnPin.Click += new System.EventHandler(this.BtnPin_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(551, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(584, 248);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.txtConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmConsole";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConsole_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtConsole.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.MemoEdit txtConsole;
        private DevExpress.XtraEditors.SimpleButton btnPin;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}