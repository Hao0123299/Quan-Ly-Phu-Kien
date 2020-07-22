using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.cs
{
    public class DangkyDTO
    {
        private string TaiKhoan;
        public string TaiKhoan1
        {
            get => TaiKhoan;
            set => TaiKhoan = value;
        }

        private string MatKhau;
        public string MatKhau1
        {
            get => MatKhau;
            set => MatKhau = value;
        }

        private string NhapLaiMatKhau;
        public string NhapLaiMatKhau1
        {
            get => NhapLaiMatKhau;
            set => NhapLaiMatKhau = value;
        }  

        public DangkyDTO(string TaiKhoan, string MatKhau, string NhapLaiMatKau)
        {
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
           // this.NhapLaiMatKhau = NhapLaiMatKhau;
        }
        public DangkyDTO(DataRow row)
        {
            this.TaiKhoan = row["TaiKhoan"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
           // this.NhapLaiMatKhau = row["NhapLaiMatKhau"].ToString();
        }

    }
}
