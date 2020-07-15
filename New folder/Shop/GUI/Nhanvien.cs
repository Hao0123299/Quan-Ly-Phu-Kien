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
        }
    }
}