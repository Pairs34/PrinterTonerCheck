namespace PrinterTonerCheck.Forms
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpPrinterAdd = new DevExpress.XtraEditors.GroupControl();
            this.cbNeedMail = new System.Windows.Forms.CheckBox();
            this.cbSnmpVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSavePrinter = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrinterIp = new DevExpress.XtraEditors.TextEdit();
            this.cbPrinterType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPrinterName = new DevExpress.XtraEditors.TextEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSavePrinterList = new DevExpress.XtraEditors.SimpleButton();
            this.grpJob = new DevExpress.XtraEditors.GroupControl();
            this.txtMin = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ckSendMail = new DevExpress.XtraEditors.CheckEdit();
            this.btnSaveJob = new DevExpress.XtraEditors.SimpleButton();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.lblMail = new System.Windows.Forms.Label();
            this.cbJobType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblJobType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpPrinterAdd)).BeginInit();
            this.grpPrinterAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSnmpVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrinterIp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrinterType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrinterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpJob)).BeginInit();
            this.grpJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSendMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbJobType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPrinterAdd
            // 
            this.grpPrinterAdd.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpPrinterAdd.CaptionImageOptions.Image")));
            this.grpPrinterAdd.Controls.Add(this.cbNeedMail);
            this.grpPrinterAdd.Controls.Add(this.cbSnmpVersion);
            this.grpPrinterAdd.Controls.Add(this.btnSavePrinter);
            this.grpPrinterAdd.Controls.Add(this.txtPrinterIp);
            this.grpPrinterAdd.Controls.Add(this.cbPrinterType);
            this.grpPrinterAdd.Controls.Add(this.txtPrinterName);
            this.grpPrinterAdd.Location = new System.Drawing.Point(13, 13);
            this.grpPrinterAdd.Name = "grpPrinterAdd";
            this.grpPrinterAdd.Size = new System.Drawing.Size(533, 155);
            this.grpPrinterAdd.TabIndex = 0;
            this.grpPrinterAdd.Text = "Printer Ekle";
            // 
            // cbNeedMail
            // 
            this.cbNeedMail.AutoSize = true;
            this.cbNeedMail.Location = new System.Drawing.Point(240, 107);
            this.cbNeedMail.Name = "cbNeedMail";
            this.cbNeedMail.Size = new System.Drawing.Size(99, 17);
            this.cbNeedMail.TabIndex = 5;
            this.cbNeedMail.Text = "Mail Gönderilsin";
            this.cbNeedMail.UseVisualStyleBackColor = true;
            // 
            // cbSnmpVersion
            // 
            this.cbSnmpVersion.Location = new System.Drawing.Point(5, 104);
            this.cbSnmpVersion.Name = "cbSnmpVersion";
            this.cbSnmpVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSnmpVersion.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSnmpVersion.Properties.NullValuePrompt = "Snmp Version";
            this.cbSnmpVersion.Size = new System.Drawing.Size(208, 20);
            this.cbSnmpVersion.TabIndex = 4;
            // 
            // btnSavePrinter
            // 
            this.btnSavePrinter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePrinter.ImageOptions.Image")));
            this.btnSavePrinter.Location = new System.Drawing.Point(453, 125);
            this.btnSavePrinter.Name = "btnSavePrinter";
            this.btnSavePrinter.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrinter.TabIndex = 3;
            this.btnSavePrinter.Text = "Kaydet";
            this.btnSavePrinter.Click += new System.EventHandler(this.BtnSavePrinter_Click);
            // 
            // txtPrinterIp
            // 
            this.txtPrinterIp.EditValue = "";
            this.txtPrinterIp.Location = new System.Drawing.Point(6, 76);
            this.txtPrinterIp.Name = "txtPrinterIp";
            this.txtPrinterIp.Properties.Mask.EditMask = "([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9" +
    "]|2[0-4][0-9]|25[0-5])){3}";
            this.txtPrinterIp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrinterIp.Properties.NullValuePrompt = "Ip Adresi";
            this.txtPrinterIp.Size = new System.Drawing.Size(522, 20);
            this.txtPrinterIp.TabIndex = 2;
            // 
            // cbPrinterType
            // 
            this.cbPrinterType.Location = new System.Drawing.Point(6, 50);
            this.cbPrinterType.Name = "cbPrinterType";
            this.cbPrinterType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPrinterType.Properties.Items.AddRange(new object[] {
            "HP",
            "KyoceraColor",
            "KyoceraBlack",
            "Canon"});
            this.cbPrinterType.Properties.NullValuePrompt = "Printer Tipi";
            this.cbPrinterType.Size = new System.Drawing.Size(522, 20);
            this.cbPrinterType.TabIndex = 1;
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.EditValue = "";
            this.txtPrinterName.Location = new System.Drawing.Point(6, 23);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Properties.NullValuePrompt = "Printer Adı";
            this.txtPrinterName.Size = new System.Drawing.Size(522, 20);
            this.txtPrinterName.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(13, 186);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(775, 252);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsLayout.StoreAllOptions = true;
            this.gridView.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.GridView_PopupMenuShowing);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDelete)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "Sil";
            this.barBtnDelete.Id = 0;
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnDelete_ItemClick);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnDelete});
            this.barManager.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 477);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 477);
            // 
            // btnSavePrinterList
            // 
            this.btnSavePrinterList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSavePrinterList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePrinterList.ImageOptions.Image")));
            this.btnSavePrinterList.Location = new System.Drawing.Point(13, 445);
            this.btnSavePrinterList.Name = "btnSavePrinterList";
            this.btnSavePrinterList.Size = new System.Drawing.Size(81, 24);
            this.btnSavePrinterList.TabIndex = 6;
            this.btnSavePrinterList.Text = "Kaydet";
            this.btnSavePrinterList.Click += new System.EventHandler(this.BtnSavePrinterList_Click);
            // 
            // grpJob
            // 
            this.grpJob.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpJob.CaptionImageOptions.Image")));
            this.grpJob.Controls.Add(this.txtMin);
            this.grpJob.Controls.Add(this.label1);
            this.grpJob.Controls.Add(this.ckSendMail);
            this.grpJob.Controls.Add(this.btnSaveJob);
            this.grpJob.Controls.Add(this.txtMail);
            this.grpJob.Controls.Add(this.lblMail);
            this.grpJob.Controls.Add(this.cbJobType);
            this.grpJob.Controls.Add(this.lblJobType);
            this.grpJob.Location = new System.Drawing.Point(552, 13);
            this.grpJob.Name = "grpJob";
            this.grpJob.Size = new System.Drawing.Size(236, 155);
            this.grpJob.TabIndex = 7;
            this.grpJob.Text = "Job Setting";
            // 
            // txtMin
            // 
            this.txtMin.EditValue = "";
            this.txtMin.Location = new System.Drawing.Point(76, 99);
            this.txtMin.MenuManager = this.barManager;
            this.txtMin.Name = "txtMin";
            this.txtMin.Properties.Mask.EditMask = "n0";
            this.txtMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMin.Properties.NullText = "Minimum";
            this.txtMin.Size = new System.Drawing.Size(143, 20);
            this.txtMin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minimum";
            // 
            // ckSendMail
            // 
            this.ckSendMail.Location = new System.Drawing.Point(76, 77);
            this.ckSendMail.MenuManager = this.barManager;
            this.ckSendMail.Name = "ckSendMail";
            this.ckSendMail.Properties.Caption = "Oto mail gönder";
            this.ckSendMail.Size = new System.Drawing.Size(143, 20);
            this.ckSendMail.TabIndex = 5;
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveJob.ImageOptions.Image")));
            this.btnSaveJob.Location = new System.Drawing.Point(107, 125);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJob.TabIndex = 4;
            this.btnSaveJob.Text = "Kaydet";
            this.btnSaveJob.Click += new System.EventHandler(this.BtnSaveJob_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(76, 50);
            this.txtMail.MenuManager = this.barManager;
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.NullText = "Mail Adresi";
            this.txtMail.Size = new System.Drawing.Size(143, 20);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(8, 53);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(58, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail Adresi";
            // 
            // cbJobType
            // 
            this.cbJobType.Location = new System.Drawing.Point(76, 23);
            this.cbJobType.MenuManager = this.barManager;
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbJobType.Properties.Items.AddRange(new object[] {
            "Gunluk",
            "Haftalik",
            "Saatlik",
            "HerDakika"});
            this.cbJobType.Properties.NullText = "Job Türü";
            this.cbJobType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbJobType.Size = new System.Drawing.Size(143, 20);
            this.cbJobType.TabIndex = 1;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new System.Drawing.Point(5, 26);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(49, 13);
            this.lblJobType.TabIndex = 0;
            this.lblJobType.Text = "Job Türü";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.grpJob);
            this.Controls.Add(this.btnSavePrinterList);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.grpPrinterAdd);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.Shown += new System.EventHandler(this.FrmSettings_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpPrinterAdd)).EndInit();
            this.grpPrinterAdd.ResumeLayout(false);
            this.grpPrinterAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSnmpVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrinterIp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrinterType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrinterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpJob)).EndInit();
            this.grpJob.ResumeLayout(false);
            this.grpJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSendMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbJobType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpPrinterAdd;
        private DevExpress.XtraEditors.ComboBoxEdit cbPrinterType;
        private DevExpress.XtraEditors.TextEdit txtPrinterName;
        private DevExpress.XtraEditors.TextEdit txtPrinterIp;
        private DevExpress.XtraEditors.SimpleButton btnSavePrinter;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnSavePrinterList;
        private DevExpress.XtraEditors.GroupControl grpJob;
        private DevExpress.XtraEditors.ComboBoxEdit cbJobType;
        private System.Windows.Forms.Label lblJobType;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private System.Windows.Forms.Label lblMail;
        private DevExpress.XtraEditors.SimpleButton btnSaveJob;
        private DevExpress.XtraEditors.CheckEdit ckSendMail;
        private DevExpress.XtraEditors.TextEdit txtMin;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSnmpVersion;
        private System.Windows.Forms.CheckBox cbNeedMail;
    }
}