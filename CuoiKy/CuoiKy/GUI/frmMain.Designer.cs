namespace CuoiKy.GUI
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuMuahang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachPhieuMuaHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemHangMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHangTon = new DevExpress.XtraBars.BarButtonItem();
            this.rPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPageGrQuanTriHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPageNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPageGrDanhSachNgiepVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPagrGrQuanLyDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPageTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dockTrai = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockMenuTrai = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockTrai)).BeginInit();
            this.dockMenuTrai.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDangNhap,
            this.btnLogin,
            this.btnDoiMatKhau,
            this.btnDangKy,
            this.btnThongTinNhanVien,
            this.btnPhieuMuahang,
            this.btnPhieuBanHang,
            this.btnDanhSachPhieuMuaHang,
            this.barButtonItem1,
            this.btnThemHangMoi,
            this.btnHangTon});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPageHeThong,
            this.rPageNghiepVu,
            this.rPageDanhMuc,
            this.rPageTroGiup});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1191, 177);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 2;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 3;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký ";
            this.btnDangKy.Id = 4;
            this.btnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.Image")));
            this.btnDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.LargeImage")));
            this.btnDangKy.Name = "btnDangKy";
            // 
            // btnThongTinNhanVien
            // 
            this.btnThongTinNhanVien.Caption = "Thông tin nhân viên";
            this.btnThongTinNhanVien.Id = 5;
            this.btnThongTinNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinNhanVien.ImageOptions.Image")));
            this.btnThongTinNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongTinNhanVien.ImageOptions.LargeImage")));
            this.btnThongTinNhanVien.Name = "btnThongTinNhanVien";
            // 
            // btnPhieuMuahang
            // 
            this.btnPhieuMuahang.Caption = "Phiếu mua hàng";
            this.btnPhieuMuahang.Id = 6;
            this.btnPhieuMuahang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuMuahang.ImageOptions.Image")));
            this.btnPhieuMuahang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuMuahang.ImageOptions.LargeImage")));
            this.btnPhieuMuahang.Name = "btnPhieuMuahang";
            // 
            // btnPhieuBanHang
            // 
            this.btnPhieuBanHang.Caption = "Phiếu bán hàng";
            this.btnPhieuBanHang.Id = 7;
            this.btnPhieuBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuBanHang.ImageOptions.Image")));
            this.btnPhieuBanHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuBanHang.ImageOptions.LargeImage")));
            this.btnPhieuBanHang.Name = "btnPhieuBanHang";
            // 
            // btnDanhSachPhieuMuaHang
            // 
            this.btnDanhSachPhieuMuaHang.Caption = "Phiếu mua hang";
            this.btnDanhSachPhieuMuaHang.Id = 8;
            this.btnDanhSachPhieuMuaHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhieuMuaHang.ImageOptions.Image")));
            this.btnDanhSachPhieuMuaHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhieuMuaHang.ImageOptions.LargeImage")));
            this.btnDanhSachPhieuMuaHang.Name = "btnDanhSachPhieuMuaHang";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemHangMoi
            // 
            this.btnThemHangMoi.Caption = "Thêm hàng mới";
            this.btnThemHangMoi.Id = 10;
            this.btnThemHangMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHangMoi.ImageOptions.Image")));
            this.btnThemHangMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemHangMoi.ImageOptions.LargeImage")));
            this.btnThemHangMoi.Name = "btnThemHangMoi";
            // 
            // btnHangTon
            // 
            this.btnHangTon.Caption = "Hàng tồn";
            this.btnHangTon.Id = 11;
            this.btnHangTon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHangTon.ImageOptions.Image")));
            this.btnHangTon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHangTon.ImageOptions.LargeImage")));
            this.btnHangTon.Name = "btnHangTon";
            // 
            // rPageHeThong
            // 
            this.rPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPageGrQuanTriHeThong});
            this.rPageHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rPageHeThong.ImageOptions.Image")));
            this.rPageHeThong.Name = "rPageHeThong";
            this.rPageHeThong.Text = "Hệ thống";
            // 
            // rPageGrQuanTriHeThong
            // 
            this.rPageGrQuanTriHeThong.ItemLinks.Add(this.btnLogin);
            this.rPageGrQuanTriHeThong.ItemLinks.Add(this.btnDoiMatKhau);
            this.rPageGrQuanTriHeThong.ItemLinks.Add(this.btnDangKy);
            this.rPageGrQuanTriHeThong.ItemLinks.Add(this.btnThongTinNhanVien);
            this.rPageGrQuanTriHeThong.Name = "rPageGrQuanTriHeThong";
            this.rPageGrQuanTriHeThong.Text = "Quản trị hệ thống";
            // 
            // rPageNghiepVu
            // 
            this.rPageNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPageGrDanhSachNgiepVu});
            this.rPageNghiepVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rPageNghiepVu.ImageOptions.Image")));
            this.rPageNghiepVu.Name = "rPageNghiepVu";
            this.rPageNghiepVu.Text = "Nghiệp vụ";
            // 
            // rPageGrDanhSachNgiepVu
            // 
            this.rPageGrDanhSachNgiepVu.ItemLinks.Add(this.btnPhieuMuahang);
            this.rPageGrDanhSachNgiepVu.ItemLinks.Add(this.btnPhieuBanHang);
            this.rPageGrDanhSachNgiepVu.ItemLinks.Add(this.btnDanhSachPhieuMuaHang);
            this.rPageGrDanhSachNgiepVu.Name = "rPageGrDanhSachNgiepVu";
            this.rPageGrDanhSachNgiepVu.Text = "Danh sách nghiệp vụ";
            // 
            // rPageDanhMuc
            // 
            this.rPageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPagrGrQuanLyDanhMuc});
            this.rPageDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rPageDanhMuc.ImageOptions.Image")));
            this.rPageDanhMuc.Name = "rPageDanhMuc";
            this.rPageDanhMuc.Text = "Danh mục";
            // 
            // rPagrGrQuanLyDanhMuc
            // 
            this.rPagrGrQuanLyDanhMuc.ItemLinks.Add(this.btnThemHangMoi);
            this.rPagrGrQuanLyDanhMuc.ItemLinks.Add(this.btnHangTon);
            this.rPagrGrQuanLyDanhMuc.Name = "rPagrGrQuanLyDanhMuc";
            this.rPagrGrQuanLyDanhMuc.Text = "Quản lý danh mục";
            // 
            // rPageTroGiup
            // 
            this.rPageTroGiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rPageTroGiup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rPageTroGiup.ImageOptions.Image")));
            this.rPageTroGiup.Name = "rPageTroGiup";
            this.rPageTroGiup.Text = "Trợ giúp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 524);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1191, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // dockTrai
            // 
            this.dockTrai.Form = this;
            this.dockTrai.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockMenuTrai});
            this.dockTrai.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockTrai.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockMenuTrai
            // 
            this.dockMenuTrai.Controls.Add(this.dockPanel1_Container);
            this.dockMenuTrai.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockMenuTrai.ID = new System.Guid("7d96bd06-08f0-4451-9c03-23acd32909e1");
            this.dockMenuTrai.Location = new System.Drawing.Point(-100, 0);
            this.dockMenuTrai.Name = "dockMenuTrai";
            this.dockMenuTrai.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockMenuTrai.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockMenuTrai.SavedIndex = 0;
            this.dockMenuTrai.Size = new System.Drawing.Size(200, 347);
            this.dockMenuTrai.Text = "Menu trái";
            this.dockMenuTrai.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 318);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 177);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(21, 347);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("87a46bf4-d473-46fb-9e1c-1b90ae0888bd");
            this.dockPanel1.Location = new System.Drawing.Point(0, 177);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 347);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(3, 26);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(193, 318);
            this.controlContainer1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 548);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Phụ Kiện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockTrai)).EndInit();
            this.dockMenuTrai.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPageGrQuanTriHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPageGrDanhSachNgiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageTroGiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPagrGrQuanLyDanhMuc;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnThongTinNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhieuMuahang;
        private DevExpress.XtraBars.BarButtonItem btnPhieuBanHang;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachPhieuMuaHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemHangMoi;
        private DevExpress.XtraBars.BarButtonItem btnHangTon;
        private DevExpress.XtraBars.Docking.DockManager dockTrai;
        private DevExpress.XtraBars.Docking.DockPanel dockMenuTrai;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
    }
}