using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
   public class ThongkennhapkhoViewModel
    {
        public string MaNV { get; set; }
        public string TenNv { get; set; }
        public int SoLuongNhap { get; set; }

        public ThongkennhapkhoViewModel(string maNv, string tenNv, int soLuongNhap)
        {
            MaNV = maNv;
            TenNv = tenNv;
            SoLuongNhap = soLuongNhap;
        }
    }
}
