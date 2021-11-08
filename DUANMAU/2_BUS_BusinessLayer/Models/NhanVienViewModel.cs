using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
    public class NhanVienViewModel
    {
        //tự khai báo các thuộc tính 
        public Nhanvien nhanvien { get; set; }
        //muốn thêm thuộc tính nào để phục vụ hiển thị
        public int dangnhaptrangthai { get; set; }
    }
}
