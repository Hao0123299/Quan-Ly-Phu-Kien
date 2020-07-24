using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.cs;

namespace DAO
{
    public class ChittiethoadonDAO
    {
        private static ChittiethoadonDAO instance;
        public static ChittiethoadonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChittiethoadonDAO();
                return instance;
            }
        }

        private ChittiethoadonDAO() { }

        public List<ChitiethoadonDTO> Xem()
        {
            List<ChitiethoadonDTO> chitiethoadon = new List<ChitiethoadonDTO>();

            //select dbo.HOADON.SOHD , dbo.SANPHAM.MASP  , dbo.HOADON.SOLUONG from dbo.HOADON, dbo.SANPHAM
            string query = "select dbo.HOADON.SOHD , dbo.SANPHAM.MASP  , dbo.HOADON.SL from dbo.HOADON, dbo.SANPHAM";

            DataTable data = DataProVider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                string SOHD = item["SOHD"].ToString();
                string MASP = item["MASP"].ToString();
                string SL = item["SL"].ToString();

                ChitiethoadonDTO newCthd = new ChitiethoadonDTO(SOHD, MASP, SL);
                chitiethoadon.Add(newCthd);
            }

            return chitiethoadon;
        }

       

        public bool ThemChiTietHoaDon(string SOHD, string MASP, string SL)
        {
           // INSERT INTO dbo.CTHD(SOHD, MASP, SL) VALUES('3', N'M13 ', '10')
            string query = "INSERT INTO dbo.CTHD( SOHD, MASP , SL ) " +
                    "VALUES  ( '" + SOHD + "' , '" + MASP + "' , '" + SL + "')";

             int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        

       
    }
}
