using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.DALService;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IQLNVService
    {
        string add(Nhanvien nhanvien);
        string update(Nhanvien nhanvien);
        string delete(string email);
        string checkloi(string email, string ten, string diachi, bool admin, bool user, bool hd, bool khd);
        List<Nhanvien> timkiem(string ten);
        List<Nhanvien> loadnv();
        List<NhanVienViewModel> GetlstViewNhanVienModel(); 
      
    }
}
