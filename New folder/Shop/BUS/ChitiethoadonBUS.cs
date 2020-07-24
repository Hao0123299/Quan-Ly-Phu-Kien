using DAO;
using DTO.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ChitiethoadonBUS
    {
        private static ChitiethoadonBUS instance;

        public static ChitiethoadonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChitiethoadonBUS();
                return instance;
            }
        }

        private ChitiethoadonBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = ChittiethoadonDAO.Instance.Xem();
        }
    }
}
