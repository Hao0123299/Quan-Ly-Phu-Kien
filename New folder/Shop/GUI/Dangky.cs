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
namespace GUI
{
    public partial class Dangky : DevExpress.XtraEditors.XtraForm
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            string NhapLaiMatKhau = txtNhapLaiMatKhau.Text;

            if(txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtTaiKhoan.Focus(); // đưa trỏ chut về lại tài khoản
            }
            else if(txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtTaiKhoan.Focus();
            }
            else if(txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp lai mật khẩu");
                txtNhapLaiMatKhau.Focus();
            }
            else if(txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu phải trùng với nhau");

                txtNhapLaiMatKhau.SelectAll();
            }
            else if (DangkyDAO.Instance.DangKy(TaiKhoan, MatKhau , NhapLaiMatKhau))
            {
                MessageBox.Show("Đăng ký nhân viên thành công");
            }
        }
    }
}