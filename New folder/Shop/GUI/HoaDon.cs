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
                MessageBox.Show("Thêm thong tin thành công");
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
        //click vao datagriview hien text chi tiet hoa don
        
        private void dtgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dtgvDSHH.CurrentRow.Index;
            txtHoaDon.Text = dtgvDSHH.Rows[index].Cells[0].Value.ToString();
            txtMaSP.Text = dtgvDSHH.Rows[index].Cells[1].Value.ToString();
            txtSL.Text = dtgvDSHH.Rows[index].Cells[2].Value.ToString();
        }

        //click vào datagriview hien chi tiet thong tin hóa don

        private void dtgvDSHD1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dtgvDSHD1.CurrentRow.Index;
            txtSoHoaDon.Text = dtgvDSHD1.Rows[index].Cells[0].Value.ToString();
            txtNhanVien.Text = dtgvDSHD1.Rows[index].Cells[1].Value.ToString();
           // txtNgayLap.Text = dtgvDSHD1.Rows[index].Cells[2].Value.ToString();
            txtSoLuong.Text = dtgvDSHD1.Rows[index].Cells[2].Value.ToString();
        }
    }
}