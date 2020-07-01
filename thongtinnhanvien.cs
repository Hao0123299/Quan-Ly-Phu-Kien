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

namespace frmQuanLyPhuKienThoitrang.view
{
    public partial class Thongtinnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public Thongtinnhanvien()
        {
            InitializeComponent();
        }

        private void Thongtinnhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danhsach._Danhsach' table. You can move, or remove it, as needed.
            this.danhsachTableAdapter.Fill(this.danhsach._Danhsach);
            this.Update();

        }
        private void cbbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }
}
