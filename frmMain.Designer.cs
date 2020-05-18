namespace PrinterTonerCheck
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckManuel = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnStart = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnConsole = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barTxtStatus = new DevExpress.XtraBars.BarHeaderItem();
            this.barlblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barlblCurrentWork = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnSendTestMail = new DevExpress.XtraBars.BarButtonItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnMenu,
            this.btnRefresh,
            this.btnCheckManuel,
            this.btnSettings,
            this.btnExit,
            this.barBtnStart,
            this.barBtnStop,
            this.barTxtStatus,
            this.barlblStatus,
            this.barlblCurrentWork,
            this.barBtnSendTestMail,
            this.barBtnConsole,
            this.barDockingMenuItem1,
            this.barButtonItem1});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 14;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenu)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Menü";
            this.btnMenu.Id = 0;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheckManuel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Yenile";
            this.btnRefresh.Id = 1;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRefresh_ItemClick);
            // 
            // btnCheckManuel
            // 
            this.btnCheckManuel.Caption = "Manuel Kontrol";
            this.btnCheckManuel.Id = 2;
            this.btnCheckManuel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheckManuel.ImageOptions.SvgImage")));
            this.btnCheckManuel.Name = "btnCheckManuel";
            this.btnCheckManuel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCheckManuel_ItemClick);
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "Ayarlar";
            this.btnSettings.Id = 3;
            this.btnSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSettings.ImageOptions.SvgImage")));
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSettings_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Çık";
            this.btnExit.Id = 4;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExit_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnStart),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnStop),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnConsole, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Custom 3";
            // 
            // barBtnStart
            // 
            this.barBtnStart.Caption = "Start";
            this.barBtnStart.Id = 5;
            this.barBtnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStart.ImageOptions.Image")));
            this.barBtnStart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStart.ImageOptions.LargeImage")));
            this.barBtnStart.Name = "barBtnStart";
            this.barBtnStart.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnStart_ItemClick);
            // 
            // barBtnStop
            // 
            this.barBtnStop.Caption = "Stop";
            this.barBtnStop.Enabled = false;
            this.barBtnStop.Id = 6;
            this.barBtnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStop.ImageOptions.Image")));
            this.barBtnStop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStop.ImageOptions.LargeImage")));
            this.barBtnStop.Name = "barBtnStop";
            this.barBtnStop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnStop_ItemClick);
            // 
            // barBtnConsole
            // 
            this.barBtnConsole.Caption = "Open Console";
            this.barBtnConsole.Id = 11;
            this.barBtnConsole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnConsole.ImageOptions.Image")));
            this.barBtnConsole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnConsole.ImageOptions.LargeImage")));
            this.barBtnConsole.Name = "barBtnConsole";
            this.barBtnConsole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnConsole_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTxtStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.barlblStatus)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 4";
            // 
            // barTxtStatus
            // 
            this.barTxtStatus.Caption = "İş Durumu";
            this.barTxtStatus.Id = 7;
            this.barTxtStatus.Name = "barTxtStatus";
            // 
            // barlblStatus
            // 
            this.barlblStatus.Caption = "İşlem Bekliyor";
            this.barlblStatus.Id = 8;
            this.barlblStatus.Name = "barlblStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(890, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 435);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(890, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 380);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(890, 55);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 380);
            // 
            // barlblCurrentWork
            // 
            this.barlblCurrentWork.AccessibleName = "BarCurWork";
            this.barlblCurrentWork.Id = 9;
            this.barlblCurrentWork.Name = "barlblCurrentWork";
            // 
            // barBtnSendTestMail
            // 
            this.barBtnSendTestMail.Caption = "Test Mail";
            this.barBtnSendTestMail.Id = 10;
            this.barBtnSendTestMail.Name = "barBtnSendTestMail";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 12;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 55);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(890, 380);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.GridView_RowCellStyle);
            // 
            // backWorker
            // 
            this.backWorker.WorkerSupportsCancellation = true;
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackWorker_DoWork);
            this.backWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackWorker_RunWorkerCompleted);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "SendMail";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 460);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer Toner Status Checker";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnCheckManuel;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnStart;
        private DevExpress.XtraBars.BarButtonItem barBtnStop;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarHeaderItem barTxtStatus;
        private DevExpress.XtraBars.BarStaticItem barlblStatus;
        public DevExpress.XtraBars.BarStaticItem barlblCurrentWork;
        private DevExpress.XtraBars.BarButtonItem barBtnSendTestMail;
        private DevExpress.XtraBars.BarButtonItem barBtnConsole;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        public System.ComponentModel.BackgroundWorker backWorker;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

