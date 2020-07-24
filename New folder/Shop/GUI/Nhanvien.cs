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
using BUS;
using DAO;

namespace GUI
{
    public partial class Nhanvien : DevExpress.XtraEditors.XtraForm
    {
        public Nhanvien()
        {
            InitializeComponent();
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            //NhanvienBUS.Instance.Xem(dtgvThongTin);
            Nhanvien_Load(sender, e);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MANV = txtMa.Text;
            string HOTEN = txtHoTen.Text;
            string SODT = txtSoDT.Text;
            string CMND = txtCMND.Text;

            if (NhanvienDAO.Instance.SuaNhanVien(MANV, HOTEN, SODT, CMND))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                Nhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string MANV = txtMa.Text;
            string HOTEN = txtHoTen.Text;
            string SODT = txtSoDT.Text;
            string CMND = txtCMND.Text;

            if (NhanvienDAO.Instance.ThemNhanVien(MANV, HOTEN, SODT, CMND))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                Nhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MANV = txtMa.Text;
            string HOTEN = txtHoTen.Text;
            string SODT = txtSoDT.Text;
            string CMND = txtCMND.Text;

            if (NhanvienDAO.Instance.ThemNhanVien(MANV, HOTEN, SODT, CMND))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                Nhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa nhân thất bại");
            }
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOP2DataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.sHOP2DataSet1.NHANVIEN);

        }
    }
}