using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProVider // hàm cần thiết cho data
    {
        private static DataProVider instance;

        public static DataProVider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProVider();
                }
                return DataProVider.instance;
            }
            private set
            {
                DataProVider.instance = value;
            }
        }

        private DataProVider() { }

        private string connectionStr = @"Data Source=DESKTOP-91UK9PN\SQLEXPRESS;Initial Catalog=SHOP;Integrated Security=True";


<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
        //thêm dử liệu
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dta = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dta);

                conn.Close();
            }
            return dta;
        }

        //update du lieu
        public int ExecuteNonQuery(string query, object[] parameter = null) // kiểu int số dong thành công
        {
            int dta = 0; // cho 0 dòng thành công
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dta = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return dta;
        }

        //đếm số lượng cout
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dta = 0;

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dta = cmd.ExecuteScalar();
                conn.Close();
            }
            return dta;
        }

    }
}
