using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;

namespace _2_BUS_BusinessLayer.Service
{
    public  class QlNVService : IQLNVService
    {
        private List<NhanVienViewModel> _lstNVModel;
        INhanVienService _DAL_NhanvienService; 
        private List<Nhanvien> _lstnhanviens;
        private Validateform _Validateform;
        public QlNVService()
        {
            _DAL_NhanvienService = new NhanVienService();
            _lstnhanviens = _DAL_NhanvienService.getlstNhanVien();
            _lstNVModel = new List<NhanVienViewModel>();
            _Validateform = new Validateform();
        }

       public string checkloi(string email, string ten ,string diachi,bool admin, bool user,bool hd, bool khd)
        {
            if (_Validateform.checkNull(email)|| _Validateform.checkNull(ten)||_Validateform.checkNull(diachi))
            {
                return "Không được để trống thông tin";
            }
            if (_Validateform.checkEmail(email))
            {
                return "Mời bạn nhập định dạng Email";
            }
            if (_Validateform.checkChu(ten))
            {
                return "Tên phải nhập bằng chữ";
            }
            if (admin==false&&user ==false)
            {
                return "yêu cầu bạn chọn quyền";
            }
            if (hd==false&&khd==false)
            {
                return "Bạn phải chọn trạng thái";
            }
          
                return "Bạn đã thêm đủ dữ liệu";                    
        }
        public string add(Nhanvien nhanvien)
        {  
                  return _DAL_NhanvienService.add(nhanvien);           
        }
        public string delete(string email)
        {
            return _DAL_NhanvienService.delete(email);
        }
        public List<NhanVienViewModel> GetlstViewNhanVienModel()
        {
            _lstNVModel = (from a in _lstnhanviens
                          select new NhanVienViewModel()
                          {
                              nhanvien = a
                          }).ToList();
            return _lstNVModel;
        }
        public List<Nhanvien> loadnv()
        {
            return _lstnhanviens= _DAL_NhanvienService.getlstNhanVien(); 
        }
        public List<Nhanvien> timkiem(string ten)
        {
            var nv = _DAL_NhanvienService.getlstNhanVien().Where(c => c.Tennv.StartsWith(ten)).ToList();
            return _lstnhanviens = nv; 
        }
        public string update(Nhanvien nhanvien)
        {
            return _DAL_NhanvienService.update(nhanvien);
        }     
    }
}
