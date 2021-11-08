using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Service
{
    public class QLKHService : IQLKHService
    {
        private List<KhachHangViewModel> _lstKhModel;
        IKhachHangService _khachHangService;
        INhanVienService _nhanVienService;
        private List<Nhanvien> _lstNhanVien;
        private List<Khachhang> _lstkhachhang;
        public QLKHService()
        {
            _khachHangService = new KhachHangService();
            _nhanVienService = new NhanVienService();
            _lstkhachhang = _khachHangService.GetlstKhachHangs();
            _lstNhanVien = _nhanVienService.getlstNhanVien();
            _lstKhModel = new List<KhachHangViewModel>();
        }
        public string add(Khachhang khachhang)
        {
            return _khachHangService.add(khachhang);
        }
        public string delete(string sdt)
        {
            return _khachHangService.delete(sdt);
        }
        public List<Khachhang> getlstKhachHang()
        {
            return _khachHangService.GetlstKhachHangs();
        }
        public List<KhachHangViewModel> GetlstViewKhachHangModel()
        {
            var lstKHModel = (from a in _lstkhachhang
                              join b in _lstNhanVien on a.Manv equals b.Manv
                              select new KhachHangViewModel()
                              {
                                  khachhang = a,
                                  nhanvien = b,
                              }).ToList();
            return lstKHModel;                                     
        }
        public List<Khachhang> timkiem(string sdt)
        {
            var KH = _khachHangService.GetlstKhachHangs().Where(c => c.Dienthoai.StartsWith(sdt)).ToList();
            return _lstkhachhang = KH;
        }
        public string update(Khachhang khachhang)
        {
            return _khachHangService.update(khachhang);
        }
    }
}
