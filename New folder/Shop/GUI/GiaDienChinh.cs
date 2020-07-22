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
    }
}