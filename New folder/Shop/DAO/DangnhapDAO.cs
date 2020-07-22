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
    public class DangnhapDAO
    {
        private static DangnhapDAO instance;

        public static DangnhapDAO Instance
        {
            get { if (instance == null) instance = new DangnhapDAO(); return instance; }
            private set { instance = value;  }
        }

        private DangnhapDAO() { }

        public bool XacNhan(string TaiKhoan, string MatKhau)
        {
            string query = "USP_Account @TaiKhoan , @MatKhau";

            DataTable result = DataProVider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });

            return result.Rows.Count > 0; // số dong lớn hơn 0
         
        }

        public DangnhapDTO GetTaiKhoan (string TaiKhoan)
        {
            DataTable data = DataProVider.Instance.ExecuteQuery("select * from Account where TaiKhoan ='" +TaiKhoan+"'");
             
            foreach (DataRow item in data.Rows)
            {
                return new DangnhapDTO(item);
            }
            return null;
        }
    }
}
