using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAO;
using BUS;

namespace GUI
{
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        //xem chi tiết hóa đơn
        private void btnXem_Click(object sender, EventArgs e)
        {
            ChitiethoadonBUS.Instance.Xem(dtgvDSHH);
        }
        //xem thông tin hóa đon
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            HoadonBUS.Instance.Xem(dtgvDSHD1);
        }
        //thêm thong tin hóa đơn
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {

            string SOHD = txtSoHoaDon.Text;
            string MANV = txtNhanVien.Text;
            string SL = txtSL.Text;


            if(HoadonDAO.Instance.ThemHoaDon(SOHD, MANV, SL))
            {
                MessageBox.Show("Thêm thông tin thành công");
                HoadonBUS.Instance.Xem(dtgvDSHD1);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        //thêm chi tiết hóa đơn
        private void btnThem_Click(object sender, EventArgs e)
        {
            string SOHD = txtHoaDon.Text;
            string MASP = txtMaSP.Text;
            string SL = txtSL.Text;
        

            if (ChittiethoadonDAO.Instance.ThemChiTietHoaDon(SOHD, MASP, SL))
            {
                MessageBox.Show("Thêm chi tiết hóa đơn");
                ChitiethoadonBUS.Instance.Xem(dtgvDSHH);
            }
            else
            {
                MessageBox.Show("Thất bại, vui lòng kiểm tra lại");
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOP2DataSet5.CTHD' table. You can move, or remove it, as needed.
            this.cTHDTableAdapter.Fill(this.sHOP2DataSet5.CTHD);
            // TODO: This line of code loads data into the 'sHOP2DataSet2.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.sHOP2DataSet2.HOADON);

        }
    }
}