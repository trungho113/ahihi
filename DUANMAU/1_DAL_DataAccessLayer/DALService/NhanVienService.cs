using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Context;

namespace _1_DAL_DataAccessLayer.DALService
{
   public class NhanVienService : INhanVienService
    {

        private List<Nhanvien> _lstNhanVien;
        private DatabaseContext _DatabaseContext;

        public NhanVienService()
        {
            _lstNhanVien = new List<Nhanvien>();
            _DatabaseContext = new DatabaseContext();
            getlstNhanVienfromDB();
        }

        public string add(Nhanvien nhanvien)
        {
            _DatabaseContext.Nhanviens.Add(nhanvien);
            _DatabaseContext.SaveChanges();
            getlstNhanVienfromDB();
            return "Thêm thành công";
        }

        public string delete(string email)
        {
            var acc = getlstNhanVien().FirstOrDefault(c => c.Email ==email);
            acc.Tinhtrang = false;
            _DatabaseContext.Nhanviens.Update(acc);
            _DatabaseContext.SaveChanges();
            getlstNhanVienfromDB();
            return "Xóa thành công";
            
        }

        public List<Nhanvien> getlstNhanVien()
        {
            return _lstNhanVien;
        }

        public void getlstNhanVienfromDB()
        {
            _lstNhanVien = _DatabaseContext.Nhanviens.ToList();
        }

        public string update(Nhanvien nhanvien)
        {
    
            _DatabaseContext.Nhanviens.Update(nhanvien);
            _DatabaseContext.SaveChanges();
            getlstNhanVienfromDB();
            return "Sửa thành công";
        }
        //public string SaveData()
        //{
           
        //    return " Lưu Thành Công";
        //}
    }
}
