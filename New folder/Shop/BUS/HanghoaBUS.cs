using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class HangHoaBUS
    {
        private static HangHoaBUS instance;

        public static HangHoaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangHoaBUS();
                return instance;
            }
        }

        private HangHoaBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = HanghoaDAO.Instance.Xem();
        }
    }
}
