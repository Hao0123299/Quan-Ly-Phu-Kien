﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class HangHoa
    {
        //mã sp
        private string MASP;
        public string MASP1
        {
            get => MASP;
            set => MASP = value;
        }
    
        //tên hàng
        private string TENSP;
        public string TENSP1
        {
            get => TENSP;
            set => TENSP = value;
        }
        //đơn giá
        private string GIA;
        public string GIA1
        {
            get => GIA;
            set => GIA = value;
        }

        private string DVT;
        public string _DVT
        {
            get => DVT;
            set => DVT = value;
        }
        
        public HangHoa(string MASP, string TENSP, string GIA, string DVT)
        {
            this.MASP = MASP;
            this.TENSP = TENSP;
            this.DVT = DVT;
            this.GIA = GIA;
            
        }
        public HangHoa(DataRow row)
        {
            this.MASP = row["MASP"].ToString();
            this.TENSP = row["TENSP"].ToString();
            this.DVT = row["DVT"].ToString();
            this.GIA = row["GIA"].ToString();
            
        }
    }
}
