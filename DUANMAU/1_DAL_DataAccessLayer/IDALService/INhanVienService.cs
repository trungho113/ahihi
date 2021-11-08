using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.DALService;

namespace _1_DAL_DataAccessLayer.IDALService
{
  public interface INhanVienService
    {
        string add(Nhanvien nhanvien);
        string update(Nhanvien nhanvien);
        string delete(string email);
        List<Nhanvien> getlstNhanVien();
        void getlstNhanVienfromDB();
      



    }
}
