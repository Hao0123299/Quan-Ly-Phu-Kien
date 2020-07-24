using DTO.cs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoadonDAO
    {
        private static HoadonDAO instance;
        public static HoadonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoadonDAO();
                return instance;
            }
        }

        private HoadonDAO() { }

        public List<HoadonDTO> Xem()
        {
            List<HoadonDTO> hoadon = new List<HoadonDTO>();

            string query = "select SOHD , NGHD, MANV , SOLUONG from dbo.HOADON";


            DataTable data = DataProVider.Instance.ExecuteQuery(query);


            foreach (DataRow item in data.Rows)
            {

                string SOHD = item["SOHD"].ToString();
               // DateTime NGHD = (DateTime)item["NGHD"];
                string MANV = item["MANV"].ToString();
                string SOLUONG = item["SOLUONG"].ToString();

                HoadonDTO newHdd = new HoadonDTO(SOHD, MANV , SOLUONG);
                hoadon.Add(newHdd);
            }

            return hoadon;
        }

        public bool ThemHoaDon(string SOHD, string MANV, string SOLUONG)
        {
         

            string query = "INSERT INTO dbo.HOADON ( SOHD, MANV  , SOLUONG ) " +
                    "VALUES  ( '" + SOHD + "' , N'" + MANV + "' , '" + SOLUONG + "')";

            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
