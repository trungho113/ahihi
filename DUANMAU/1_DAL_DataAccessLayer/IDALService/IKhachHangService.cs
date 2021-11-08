using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.DALService;
namespace _1_DAL_DataAccessLayer.IDALService
{
   public  interface IKhachHangService
    {
        string add(Khachhang khachhang);
        string update(Khachhang khachhang);
        string delete(string sdt);
        List<Khachhang> GetlstKhachHangs();
        void GetlstKhachHangFromDB();
    }
}
