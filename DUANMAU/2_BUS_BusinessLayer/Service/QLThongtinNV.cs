using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.DALService;


namespace _2_BUS_BusinessLayer.Service
{
    public class QLThongtinNV : IQLThongtinNV
    {
        INhanVienService _NhanvienService;
        public QLThongtinNV()
        {
            _NhanvienService = new NhanVienService(); 
        }
        public string updatePassword(string email,string mkcu, string mkmoi)
        {
            var laymk = _NhanvienService.getlstNhanVien().Where(c => c.Email == email).Select(c => c.Matkhau).FirstOrDefault();
            if (mkcu==laymk)
            {
                var mk = _NhanvienService.getlstNhanVien().FirstOrDefault(c => c.Email == email);
                 mk.Matkhau = mkmoi;
                _NhanvienService.update(mk);
                  return "Thay đổi mật khẩu thành công";
            }
            else
            {
                return "Mật khẩu cũ không đúng";
            }
        }
        public bool checkmkcu(string mkcu, string email)
        {
            var laymk = _NhanvienService.getlstNhanVien().Where(c => c.Email == email).Select(c => c.Matkhau).FirstOrDefault();
            if (mkcu == laymk) return false;
            else
            {
                return true;
            }
        }
    }
}
