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
<<<<<<< HEAD
using DAO;
=======
<<<<<<< HEAD
using DAO;
=======
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5

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
            NhanvienBUS.Instance.Xem(dtgvThongTin);
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
           
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
                    NhanvienBUS.Instance.Xem(dtgvThongTin);
                }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        
        private void dtgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvThongTin.CurrentRow.Index;
            txtMa.Text = dtgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dtgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtSoDT.Text = dtgvThongTin.Rows[i].Cells[2].Value.ToString();
            txtCMND.Text = dtgvThongTin.Rows[i].Cells[3].Value.ToString();
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
                NhanvienBUS.Instance.Xem(dtgvThongTin);
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
                NhanvienBUS.Instance.Xem(dtgvThongTin);
            }
            else
            {
                MessageBox.Show("Xóa nhân thất bại");
            }
        }
        //click vào datagriview hien chi tiet
        int index;
        private void dtgvThongTin_Click(object sender, EventArgs e)
        {
            index = dtgvThongTin.CurrentRow.Index;
            txtMa.Text = dtgvThongTin.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dtgvThongTin.Rows[index].Cells[1].Value.ToString();
            txtSoDT.Text = dtgvThongTin.Rows[index].Cells[2].Value.ToString();
            txtCMND.Text = dtgvThongTin.Rows[index].Cells[3].Value.ToString();
        }

        
<<<<<<< HEAD
=======
=======
        }
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
    }
}