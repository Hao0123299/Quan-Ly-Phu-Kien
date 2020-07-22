using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class KhachhangBUS
    {
        private static KhachhangBUS instance;

        public static KhachhangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachhangBUS();
                return instance;
            }
        }

        private KhachhangBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = KhachhangDAO.Instance.Xem();
        }
    }
}
