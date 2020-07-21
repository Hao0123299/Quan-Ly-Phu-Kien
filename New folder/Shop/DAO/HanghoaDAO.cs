using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HanghoaDAO
    {
        private static HanghoaDAO instance;
        public static HanghoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HanghoaDAO();
                return instance;
            }
        }

        private HanghoaDAO() { }

        public List<HangHoa> Xem()
        {
            List<HangHoa> hanghoa = new List<HangHoa>();

<<<<<<< HEAD
            string query = "select MASP , TENSP, DVT, GIA from SANPHAM";
            
            
            DataTable data = DataProVider.Instance.ExecuteQuery(query);
            
=======
            string query = "select * from SANPHAM";

            DataTable data = DataProVider.Instance.ExecuteQuery(query);
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f

            foreach (DataRow item in data.Rows)
            {

                string MASP = item["MASP"].ToString();
                string TENSP = item["TENSP"].ToString();
                string DVT = item["DVT"].ToString();
                string GIA = item["GIA"].ToString();
<<<<<<< HEAD
              
                HangHoa newHh = new HangHoa(MASP, TENSP, DVT, GIA);
=======
                

                HangHoa newHh = new HangHoa(MASP, TENSP, GIA, DVT);
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
                hanghoa.Add(newHh);
            }

            return hanghoa;
        }

<<<<<<< HEAD
        public bool Sua(string MASP , string TENSP , string DVT , string GIA)
        { 
            string query = "UPDATE dbo.SANPHAM SET TENSP = '" + TENSP + "' , DVT = '" + DVT + "' , GIA = '" + GIA + "'  WHERE MASP = '" + MASP + "'" ;
            
=======
        public bool Sua(string MASP, string TENSP, string DVT, string GIA)
        { 
            string query = " UPDATE dbo.SANPHAM SET TENSP = '"+TENSP+"' , DVT = '"+DVT+"' , GIA = '"+GIA+"'  WHERE MASP = MASP";
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
            int result = DataProVider.Instance.ExecuteNonQuery(query);
            return result > 0;           
        }

        public bool Them(string MASP, string TENSP, string DVT,  string GIA)
<<<<<<< HEAD
        {       
            string query = "INSERT INTO dbo.SANPHAM ( MASP, TENSP, DVT, GIA ) " +
                    "VALUES  ( '"+ MASP +"', N'"+ TENSP +"','"+ DVT +"', "+ GIA+")";

            int result = DataProVider.Instance.ExecuteNonQuery(query);
=======
        {
            // string query = "INSERT dbo.SANPHAM (MASP, TENSP, DVT, GIA) VALUES(N'Ma01'"
            //string query = "INSERT INTO dbo.SANPHAM ( MASP, TENSP, DVT, GIA ) VALUES  ( '', N'', '', '')";

            string query = "INSERT INTO dbo.SANPHAM ( MASP, TENSP, DVT, GIA ) " +
                    "VALUES  ( '"+ MASP +"', N'"+ TENSP +"','"+ DVT +"', "+ GIA+")";


            //int result = DataProVider.Instance.ExecuteNonQuery(query, new object[] { MASP , TENSP, DVT,GIA });

            int result = DataProVider.Instance.ExecuteNonQuery(query);

>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
            return result > 0;
        }

        public HangHoa GetHangHoa(string MASP)
        {
<<<<<<< HEAD
            DataTable data = DataProVider.Instance.ExecuteQuery("select * from SANPHAM where MASP ='" + MASP + "'");
=======
            DataTable data = DataProVider.Instance.ExecuteQuery("select * from Account where TaiKhoan ='" + MASP + "'");
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f

            foreach (DataRow item in data.Rows)
            {
                return new HangHoa(item);
            }
            return null;
        }

        public bool Xoa(string MASP)
        {
<<<<<<< HEAD
            string query = "DELETE dbo.SANPHAM WHERE MASP = '" + MASP + "'";
=======
            string query = "DELETE dbo.SANPHAM WHERE MASP = MASP";
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
