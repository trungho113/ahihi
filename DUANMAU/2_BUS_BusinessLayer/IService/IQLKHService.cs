using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.IDALService;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IQLKHService
    {
        string add(Khachhang khachhang);
        string update(Khachhang khachhang);
        string delete(string sdt); 
        List<KhachHangViewModel> GetlstViewKhachHangModel();
        List<Khachhang> getlstKhachHang();
        List<Khachhang> timkiem(string sdt);
    }
}
