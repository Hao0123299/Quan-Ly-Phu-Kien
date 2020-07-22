using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.cs;

namespace DAO
{
    public class NhanvienDAO
    {
        private static NhanvienDAO instance;
        public static NhanvienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanvienDAO();
                return instance;
            }
        }

        private NhanvienDAO() { }

        public List<NhanvienDTO> Xem()
        {
            List<NhanvienDTO> nhanvien = new List<NhanvienDTO>();

        
            string query = "select MANV , HOTEN  , SODT , CMND from NHANVIEN";

            DataTable data = DataProVider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {

                string MANV = item["MANV"].ToString();
                string HOTEN = item["HOTEN"].ToString();
                string SODT = item["SODT"].ToString();
                string CMND = item["CMND"].ToString();



                NhanvienDTO newNv = new NhanvienDTO(MANV, HOTEN, SODT, CMND);
                nhanvien.Add(newNv);
            }

            return nhanvien;
        }

       public bool SuaNhanVien(string MANV, string HOTEN, string SODT, string CMND )
        {
            string query = " UPDATE dbo.NHANVIEN SET  HOTEN  = '" + HOTEN + "' , SODT = '" + SODT +"' , CMND = '" + CMND + "'  WHERE MANV = '" + MANV +"'" ;
            int result = DataProVider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemNhanVien(string MANV, string HOTEN, string SODT, string CMND)
        {

            string query = "INSERT INTO dbo.NHANVIEN ( MANV, HOTEN, SODT, CMND ) " +
                    "VALUES  ( '" + MANV + "' , N'" + HOTEN + "' , '" + SODT + "' , " + CMND + ")";

            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

       /* public HangHoa GetHangHoa(string MASP)
        {
            DataTable data = DataProVider.Instance.ExecuteQuery("select * from Account where TaiKhoan ='" + MASP + "'");

            foreach (DataRow item in data.Rows)
            {
                return new HangHoa(item);
            }
            return null;
        }*/

        public bool XoaNhanVien(string MANV)
        {
            string query = "  DELETE dbo.NHANVIEN WHERE MANV ='" + MANV +"'" ;
            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

