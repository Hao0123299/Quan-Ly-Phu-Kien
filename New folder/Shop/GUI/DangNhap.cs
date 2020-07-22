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
using GUI;
using DTO.cs;

namespace GUI
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;

            if (XacNhan(TaiKhoan, MatKhau))
            {
                DangnhapDTO XacNhan = DangnhapDAO.Instance.GetTaiKhoan(TaiKhoan);
                GiaDienChinh f = new GiaDienChinh(XacNhan);
                this.Hide();
                MessageBox.Show("Đăng nhập thành công");
                f.ShowDialog();
                this.Hide();  
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool XacNhan(string TaiKhoan, string MatKhau)
        {
            return DangnhapDAO.Instance.XacNhan(TaiKhoan, MatKhau);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn cso muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}