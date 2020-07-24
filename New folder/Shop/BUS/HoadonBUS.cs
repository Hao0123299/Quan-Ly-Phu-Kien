using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class HoadonBUS
    {
        private static HoadonBUS instance;

        public static HoadonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoadonBUS();
                return instance;
            }
        }

        private HoadonBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = HoadonDAO.Instance.Xem();
        }
    }
}
