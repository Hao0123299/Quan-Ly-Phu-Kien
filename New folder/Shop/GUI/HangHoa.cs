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
    public partial class HangHoa : DevExpress.XtraEditors.XtraForm
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //HangHoaBUS.Instance.Xem(dtgvDS);
            HangHoa_Load( sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MASP = txtMa.Text;
            string TENSP = txtTen.Text;
            string DVT = txtDonViTinh.Text;
            string GIA = txtDonGia.Text;


            if (HanghoaDAO.Instance.Sua(MASP, TENSP, DVT, GIA))
            {
                MessageBox.Show("Sửa hàng thành công");
                HangHoa_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa hàng thất bại");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MASP = txtMa.Text;
            string TENSP = txtTen.Text;
            string DVT = txtDonViTinh.Text;
            string GIA = txtDonGia.Text;

            if (HanghoaDAO.Instance.Them(MASP , TENSP , DVT , GIA))
            {
                MessageBox.Show("Thêm hàng thành công");
                HangHoa_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm hàng thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MASP = txtMa.Text;
            string TENSP = txtTen.Text;
            string DVT = txtDonViTinh.Text;
            string GIA = txtDonGia.Text;

            if (HanghoaDAO.Instance.Xoa(MASP))
            {
                MessageBox.Show("Xóa hàng thành công");
                HangHoa_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa hàng thất bại");
            }

        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOP2DataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.sHOP2DataSet.SANPHAM);

        }
    }
}