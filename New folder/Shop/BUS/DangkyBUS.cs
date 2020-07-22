using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangkyBUS
    {
        private static DangkyBUS instance;

        public static DangkyBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangkyBUS();
                return instance;
            }
        }

        private DangkyBUS() { }
    }
}
