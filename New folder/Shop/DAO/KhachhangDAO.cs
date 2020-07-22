using DTO;
using DTO.cs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachhangDAO
    {
        private static KhachhangDAO instance;
        public static KhachhangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachhangDAO();
                return instance;
            }
        }

        private KhachhangDAO() { }

        public List<KhachhangDTO> Xem()
        {
            List<KhachhangDTO> khachhang = new List<KhachhangDTO>();

            string query = "select * from ";


            DataTable data = DataProVider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {

                string MAKH = item["MAKH"].ToString();
                string HOTEN = item["HOTEN"].ToString();
                string DCHI = item["DCHI"].ToString();
                string SODT = item["SODT"].ToString();
                string EMAIL = item["EMAIL"].ToString();

                KhachhangDTO newKh = new KhachhangDTO(MAKH, HOTEN , DCHI , SODT , EMAIL);
                khachhang.Add(newKh);
            }

            return khachhang;
        }
    }
}
