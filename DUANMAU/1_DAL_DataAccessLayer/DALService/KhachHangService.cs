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
    public class KhachHangService : IKhachHangService
    {

        private List<Khachhang> _lstKhachHang;
        private DatabaseContext _DatabaseContext;
        public KhachHangService()
        {
            _lstKhachHang = new List<Khachhang>();
            _DatabaseContext = new DatabaseContext();
            GetlstKhachHangFromDB();
        }
        public string add(Khachhang khachhang)
        {
            _DatabaseContext.Khachhangs.Add(khachhang);
            _DatabaseContext.SaveChanges();
            GetlstKhachHangFromDB();
            return "Thêm thành công";
        }

        public string delete(string sdt)
        {
            var acc = GetlstKhachHangs().FirstOrDefault(c => c.Dienthoai == sdt);
            _DatabaseContext.Khachhangs.Remove(acc);
            _DatabaseContext.SaveChanges();
            GetlstKhachHangFromDB();
            return "Xóa thành công";
        }

        public void GetlstKhachHangFromDB()
        {
            _lstKhachHang = _DatabaseContext.Khachhangs.ToList();
        }

        public List<Khachhang> GetlstKhachHangs()
        {
            return _lstKhachHang;
        }

        public string update(Khachhang khachhang)
        {
            _DatabaseContext.Khachhangs.Update(khachhang);
            _DatabaseContext.SaveChanges();
            GetlstKhachHangFromDB();
            return "Sửa thành công";
        }
    }
}
