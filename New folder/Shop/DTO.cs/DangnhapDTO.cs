using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.cs
{
    public class DangnhapDTO
    {
        public DangnhapDTO (string TaiKhoan, string MatKhau = null)
        {
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            //this.quyen = Quyen;
        }

        public DangnhapDTO(DataRow row)
        {
            this.TaiKhoan = row["taiKhoan"].ToString();
            this.MatKhau = row["matKhau"].ToString();
           // this.quyen = row["Quyen"].ToString();
        }

        private string TaiKhoan;
        public string taiKhoan
        {
            get => TaiKhoan;
            set => TaiKhoan = value;
        }
        private string MatKhau;
        public string matKhau
        {
            get => MatKhau;
            set => MatKhau = value;
        }

        /*private string quyen;
        public string Quyen
        {
            get => quyen;
            set => quyen = value;
        }*/

       
    }
}
