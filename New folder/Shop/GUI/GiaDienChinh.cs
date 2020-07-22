using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DTO.cs;

namespace GUI
{
    public partial class GiaDienChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaDienChinh(DangnhapDTO dangNhap)
        {
            InitializeComponent();
            skin();
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue";

        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MdiParent = this;
            hh.Show();
        }

        private void btnThongTinChiTietNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.MdiParent = this; ;
            nv.Show();
        }

        private void btnThongTinKhangHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
        private void btnDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dangky dk = new Dangky();
            dk.MdiParent = this;
            dk.Show();
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MdiParent = this;
            hd.Show();
        }

        private void btnBaoCaoCuoiNgay_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }
<<<<<<< HEAD
=======
=======
        /* private void btnThongTinChiTietNhanVien_ItemClick(object sender, ItemClickEventArgs e)
         {
             NhanVien nv = new NhanVien();
             nv.MdiParent = this;
             nv.Show();
         }*/
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
    }
}