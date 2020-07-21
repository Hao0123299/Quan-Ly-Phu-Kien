using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class NhanvienBUS
    {
        private static NhanvienBUS instance;

        public static NhanvienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanvienBUS();
                return instance;
            }
        }

        private NhanvienBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = NhanvienDAO.Instance.Xem();
        }
    }
}
