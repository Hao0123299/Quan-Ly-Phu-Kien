using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhuKienThoiTrang
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-461554B;Initial Catalog=QLPKTT;Integrated Security=True"); // lấy code từ sql
            try
            {
                Conn.Open(); // mở kết nối sql
                string tk = txtTaiKhoan.Text;  // tạo biến tài khoản và mat khâu
                string mk = txtTaiKhoan.Text;

                string sql = "select * from Account where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql,Conn); // câu lệnh sql và biến kết nối conn
                SqlDataReader data = cmd.ExecuteReader(); // lấy dữ liệu từ sql cmd và đọc dữ liệu
                if(data.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công"); //xuất thông báo ra màn hình
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối"); //xuất thông báo ra màn hình
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoat hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if(tb == DialogResult.OK)
            Application.Exit();
        }
    }
}
