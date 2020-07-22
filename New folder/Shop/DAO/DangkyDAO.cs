using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangkyDAO
    {
        private static DangkyDAO instance;
        public static DangkyDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangkyDAO();
                return instance;
            }
        }

        private DangkyDAO() { }

        public bool DangKy(string TaiKhoan, string MatKhau, string NhapLaiMatKhau)
        {

            string query = "INSERT INTO dbo.Account ( TaiKhoan, MatKhau , NhapLaiMatKhau ) " +
                    "VALUES  ( '" + TaiKhoan + "' , N'" + MatKhau + "' , '" + NhapLaiMatKhau + "')";

            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
