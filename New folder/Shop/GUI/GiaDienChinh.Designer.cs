namespace GUI
{
    partial class GiaDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaDienChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDamhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnThongTinNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.btnThongTinChiTietNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoCuoiNgay = new DevExpress.XtraBars.BarButtonItem();
            this.rbPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGrGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDoiMatKhau,
            this.btnDamhSachNhanVien,
            this.btnDangKy,
            this.skinRibbonGalleryBarItem1,
            this.btnThongTinNhanVien,
            this.barCheckItem1,
            this.btnThongTinChiTietNhanVien,
            this.barButtonItem2,
            this.btnKho,
            this.barButtonItem3,
            this.btnDoiTac,
            this.btnBanHang,
            this.btnBaoCaoCuoiNgay});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPageHeThong,
            this.rbPageQuanLy,
            this.rbPageDanhMuc});
            this.ribbon.Size = new System.Drawing.Size(1270, 177);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 1;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnDamhSachNhanVien
            // 
            this.btnDamhSachNhanVien.Caption = "Danh sách nhân viên";
            this.btnDamhSachNhanVien.Id = 2;
            this.btnDamhSachNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDamhSachNhanVien.ImageOptions.Image")));
            this.btnDamhSachNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDamhSachNhanVien.ImageOptions.LargeImage")));
            this.btnDamhSachNhanVien.Name = "btnDamhSachNhanVien";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký";
            this.btnDangKy.Id = 3;
            this.btnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.Image")));
            this.btnDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.LargeImage")));
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKy_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 4;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnThongTinNhanVien
            // 
            this.btnThongTinNhanVien.Caption = "Thông tin chi tiết nhân viên";
            this.btnThongTinNhanVien.Id = 5;
            this.btnThongTinNhanVien.Name = "btnThongTinNhanVien";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // btnThongTinChiTietNhanVien
            // 
            this.btnThongTinChiTietNhanVien.Caption = "Thông tin nhân viên";
            this.btnThongTinChiTietNhanVien.Id = 7;
            this.btnThongTinChiTietNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinChiTietNhanVien.ImageOptions.Image")));
            this.btnThongTinChiTietNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongTinChiTietNhanVien.ImageOptions.LargeImage")));
            this.btnThongTinChiTietNhanVien.Name = "btnThongTinChiTietNhanVien";
            this.btnThongTinChiTietNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinChiTietNhanVien_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 9;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnDoiTac
            // 
            this.btnDoiTac.Caption = "Đối tác";
            this.btnDoiTac.Id = 11;
            this.btnDoiTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiTac.ImageOptions.Image")));
            this.btnDoiTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiTac.ImageOptions.LargeImage")));
            this.btnDoiTac.Name = "btnDoiTac";
      
            // 
            // btnBanHang
            // 
            this.btnBanHang.Caption = "Bán hàng";
            this.btnBanHang.Id = 12;
            this.btnBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.ImageOptions.Image")));
            this.btnBanHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBanHang.ImageOptions.LargeImage")));
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanHang_ItemClick);
            // 
            // btnBaoCaoCuoiNgay
            // 
            this.btnBaoCaoCuoiNgay.Caption = "Báo cáo cuối ngày";
            this.btnBaoCaoCuoiNgay.Id = 13;
            this.btnBaoCaoCuoiNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoCuoiNgay.ImageOptions.Image")));
            this.btnBaoCaoCuoiNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoCuoiNgay.ImageOptions.LargeImage")));
            this.btnBaoCaoCuoiNgay.Name = "btnBaoCaoCuoiNgay";
            this.btnBaoCaoCuoiNgay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoCuoiNgay_ItemClick);
            // 
            // rbPageHeThong
            // 
            this.rbPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rbPageGrGiaoDien});
            this.rbPageHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbPageHeThong.ImageOptions.Image")));
            this.rbPageHeThong.Name = "rbPageHeThong";
            this.rbPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangKy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbPageGrGiaoDien
            // 
            this.rbPageGrGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rbPageGrGiaoDien.Name = "rbPageGrGiaoDien";
            this.rbPageGrGiaoDien.Text = "Giao diện";
            // 
            // rbPageQuanLy
            // 
            this.rbPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.rbPageQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbPageQuanLy.ImageOptions.Image")));
            this.rbPageQuanLy.Name = "rbPageQuanLy";
            this.rbPageQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThongTinChiTietNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDoiTac);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // rbPageDanhMuc
            // 
            this.rbPageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.rbPageDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbPageDanhMuc.ImageOptions.Image")));
            this.rbPageDanhMuc.Name = "rbPageDanhMuc";
            this.rbPageDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBanHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 438);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1270, 24);
            // 
            // GiaDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 462);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GiaDienChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm bán phụ kiện V 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDamhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnThongTinNhanVien;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem btnThongTinChiTietNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGrGiaoDien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnDoiTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnBanHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoCuoiNgay;
    }
}