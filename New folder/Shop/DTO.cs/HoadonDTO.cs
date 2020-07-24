using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.cs
{
    public class HoadonDTO
    {
        private string SOHD;

        public string SOHD1
        {
            get => SOHD;
            set => SOHD = value;
        }

       /* private DateTime NGHD;
        public DateTime NGHD1
        {
            get => NGHD;
            set => NGHD = value;
        }*/

        private string MANV;
        public string MANV1
        {
            get => MANV;
            set => MANV = value;
        }

        private string SOLUONG;
        public string SOLUONG1
        {
            get => SOLUONG;
            set => SOLUONG = value;
        }

        public HoadonDTO (string SOHD, string MANV, string SOLUONG)
        {
            this.SOHD = SOHD;
         //   this.NGHD = NGHD;
            this.MANV = MANV;
            this.SOLUONG = SOLUONG; 
        }

        public HoadonDTO(DataRow row)
        {
            this.SOHD = row["SOHD"].ToString();
         //   this.NGHD =(DateTime) row["NGHD"];
            this.MANV = row["MANV"].ToString();
            this.SOLUONG = row["SOLUONG"].ToString();
        }

    }
}
