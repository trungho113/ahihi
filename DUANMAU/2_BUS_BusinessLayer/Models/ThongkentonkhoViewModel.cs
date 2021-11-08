using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
   public class ThongkentonkhoViewModel
    {
        public string TenSp { get; set; }
        public int SoLuongTon { get; set; }

        public ThongkentonkhoViewModel(string tenSp, int soLuongTon)
        {
            TenSp = tenSp;
            SoLuongTon = soLuongTon;
        }
    }
}
