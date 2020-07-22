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
            HangHoaBUS.Instance.Xem(dtgvDS);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MASP = txtMa.Text;
            string TENSP = txtTen.Text;
            string GIA = txtDonGia.Text;
            string DVT = txtDonViTinh.Text;


            if (HanghoaDAO.Instance.Sua(MASP, TENSP, DVT, GIA))
            {
                MessageBox.Show("Sửa hàng thành công");
                HangHoaBUS.Instance.Xem(dtgvDS);
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
                HangHoaBUS.Instance.Xem(dtgvDS);
            }
            else
            {
                MessageBox.Show("Thêm hàng thất bại");
            }
        }
<<<<<<< HEAD
  
         private void btnXoa_Click(object sender, EventArgs e)
=======
<<<<<<< HEAD
  
         private void btnXoa_Click(object sender, EventArgs e)
=======

        private void dtgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvDS.CurrentRow.Index;
            txtMa.Text = dtgvDS.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dtgvDS.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dtgvDS.Rows[i].Cells[2].Value.ToString();
            txtDonViTinh.Text = dtgvDS.Rows[i].Cells[3].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
        {
            string MASP = txtMa.Text;
            string TENSP = txtTen.Text;
            string DVT = txtDonViTinh.Text;
            string GIA = txtDonGia.Text;

            if (HanghoaDAO.Instance.Xoa(MASP))
            {
                MessageBox.Show("Xóa hàng thành công");
                HangHoaBUS.Instance.Xem(dtgvDS);
            }
            else
            {
                MessageBox.Show("Xóa hàng thất bại");
            }

        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5

        //click vào datagriview hien chi tiet
        int index;
        private void dtgvDS_Click(object sender, EventArgs e)
        {
            index = dtgvDS.CurrentRow.Index;

            txtMa.Text = dtgvDS.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dtgvDS.Rows[index].Cells[1].Value.ToString();
            txtDonViTinh.Text = dtgvDS.Rows[index].Cells[2].Value.ToString();
            txtDonGia.Text = dtgvDS.Rows[index].Cells[3].Value.ToString();
        }

<<<<<<< HEAD
        private void HangHoa_Load(object sender, EventArgs e)
        {

        }
=======
      
=======
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
    }
}