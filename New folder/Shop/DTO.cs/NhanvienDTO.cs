using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO.cs
{
    public class NhanvienDTO
    {
        private string MANV;
        public string MANV1
        {
            get => MANV;
            set => MANV = value;
        }

        private string HOTEN;
        public string HOTEN1
        {
            get => HOTEN;
            set => HOTEN = value;
        }

        private string SODT;
        public string SODT1
        {
            get => SODT;
            set => SODT = value;
        }

        private string CMND;
        public string CMND1
        {
            get => CMND;
            set => CMND = value;
        }
       
        public NhanvienDTO (string MANV, string HOTEN, string SODT, string CMND)
        {
            this.MANV = MANV;
            this.HOTEN = HOTEN;
            this.SODT = SODT;
            this.CMND = CMND;
        }

        public NhanvienDTO(DataRow row)
        {
            this.MANV = row["MANV"].ToString();
            this.HOTEN = row["HOTEN"].ToString();
            this.SODT = row["SODT"].ToString();
            this.CMND = row["CMND"].ToString();
        }     
    }
}
