using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
    public class KhachHangViewModel
    {
        public Khachhang khachhang { get; set; }
        public Nhanvien nhanvien { get; set; }
    }
}
