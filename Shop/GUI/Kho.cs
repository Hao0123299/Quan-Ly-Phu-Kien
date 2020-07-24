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
    public partial class Kho : DevExpress.XtraEditors.XtraForm
    {
        public Kho()
        {
            InitializeComponent();

            LoadData();
        }

        void LoadData()
        {
            string query = "EXEC dbo.HangHoa_GetListHangHoa @TenHang "; // parameter, cắt theo khoảng trắng

            DataProVider provider = new DataProVider();

            dgvChiTiet.DataSource = provider.ExecuteQuery(query, new object[] { "10" });
        }
    }
}