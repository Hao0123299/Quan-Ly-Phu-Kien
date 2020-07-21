using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.cs
{
    public class KhachhangDTO
    {
        private string TenKH;

        public string TenKH1
        {
            get => TenKH;
            set => TenKH = value;
        }
        private string SDT;

        public string SDT1
        {
            get => SDT;
            set => SDT = value;
        }
        private string GioiTinh;
        public string GioiTinh1
        {
            get => GioiTinh;
            set => GioiTinh = value;
        }

        private string DiaChi;
        public string DiaChi1
        {
            get => DiaChi; 
            set => DiaChi = value;
        }

        public KhachhangDTO(string TenKH, string SDT, string GioiTinh, string DiaChi, string eMAIL)
        {
            this.TenKH = TenKH;
            this.SDT = SDT;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
        }

        public KhachhangDTO(DataRow row)
        {
            this.TenKH = row["TenKh"].ToString();
            this.SDT = row["SDT"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();

        }

       

        

        
    }
}
