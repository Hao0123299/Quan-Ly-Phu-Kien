﻿using System;
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

            string query = "select * from NHANVIEN";

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

        /*public bool Sua(string MASP, string TENSP, string DVT, string GIA)
        {
            string query = " UPDATE dbo.SANPHAM SET TENSP = '" + TENSP + "' , DVT = '" + DVT + "' , GIA = '" + GIA + "'  WHERE MASP = MASP";
            int result = DataProVider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Them(string MASP, string TENSP, string DVT, string GIA)
        {
            // string query = "INSERT dbo.SANPHAM (MASP, TENSP, DVT, GIA) VALUES(N'Ma01'"
            //string query = "INSERT INTO dbo.SANPHAM ( MASP, TENSP, DVT, GIA ) VALUES  ( '', N'', '', '')";

            string query = "INSERT INTO dbo.SANPHAM ( MASP, TENSP, DVT, GIA ) " +
                    "VALUES  ( '" + MASP + "', N'" + TENSP + "','" + DVT + "', " + GIA + ")";


            //int result = DataProVider.Instance.ExecuteNonQuery(query, new object[] { MASP , TENSP, DVT,GIA });

            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public HangHoa GetHangHoa(string MASP)
        {
            DataTable data = DataProVider.Instance.ExecuteQuery("select * from Account where TaiKhoan ='" + MASP + "'");

            foreach (DataRow item in data.Rows)
            {
                return new HangHoa(item);
            }
            return null;
        }

        public bool Xoa(string MASP)
        {
            string query = "DELETE dbo.SANPHAM WHERE MASP =  '" + MASP + "'";
            int result = DataProVider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }*/
    }
}

