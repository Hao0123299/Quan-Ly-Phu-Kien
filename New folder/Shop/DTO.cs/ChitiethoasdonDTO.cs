using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.cs
{
    public class ChitiethoadonDTO
    {
        private string SOHD;

        public string SOHD1
        {
            get => SOHD;
            set => SOHD = value;
        }

        private string MASP;
        public string MASP1
        {
            get => MASP;
            set => MASP = value;
        }
       /* private string MANV;
        public string MANV1
        {
            get => MANV;
            set => MANV = value;
        }*/

        

        private string SL;
        public string SL1
        {
            get => SL;
            set => SL = value;
        }
        public ChitiethoadonDTO (string SOHD, string MASP, string SL)
        {
            this.SOHD = SOHD;
            this.MASP = MASP;
            this.SL = SL;
        }

        public ChitiethoadonDTO(DataRow row)
        {
            this.SOHD = row["SOHD"].ToString();
            this.MASP = row["MASP"].ToString();
            this.SL = row["SL"].ToString();
        }
    }
}
