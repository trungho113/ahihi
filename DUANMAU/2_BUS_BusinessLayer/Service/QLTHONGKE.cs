using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;
using _2_BUS_BusinessLayer.Models;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Service
{
    public class QLTHONGKE : IQLTHONGKE
    {
        private IQLNVService _QLNVService;
        private IQLSANPHAMService _QLSANPHAMService;
        private List<Nhanvien> _lstNhanViens;
        private List<Hang> _lstHangs;
        private List<ThongkentonkhoViewModel> _lstTonKhos;
        private List<ThongkennhapkhoViewModel> _lstNhapKhos;
        private ThongkentonkhoViewModel _TKTonKho;
        private ThongkennhapkhoViewModel _TKnhapKho;
        private int _soluongnhap;
        public QLTHONGKE()
        {
            _QLNVService = new QlNVService();
            _QLSANPHAMService = new QLSANPHAMService();
            _lstNhapKhos = new List<ThongkennhapkhoViewModel>();
            _lstTonKhos = new List<ThongkentonkhoViewModel>();
            _lstHangs = _QLSANPHAMService.loadhang();
            _lstNhanViens = _QLNVService.loadnv();
        }
        public List<ThongkennhapkhoViewModel> viewNhapKhos()
        {
            try
            {
                foreach (var x in _lstNhanViens)
                {
                    _soluongnhap = _lstHangs.Where(c => c.Manv == x.Manv).Count();

                    _TKnhapKho = new ThongkennhapkhoViewModel(x.Manv, x.Tennv, _soluongnhap);
                    _lstNhapKhos.Add(_TKnhapKho);                 
                }
                var lstView = _lstNhapKhos.OrderBy(c => c.MaNV).GroupBy(c => c.MaNV)
                    .Select(g => new ThongkennhapkhoViewModel(g.Key, g.Where(c => c.MaNV == g.Key).Select(c => c.TenNv).FirstOrDefault(), g.Sum(c => c.SoLuongNhap))).ToList();
                return lstView;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<ThongkentonkhoViewModel> viewSPTonKhos()
        {
            try
            {
                foreach (var x in _lstHangs)
                {
                    _TKTonKho = new ThongkentonkhoViewModel(x.Tenhang, x.Soluong);
                    _lstTonKhos.Add(_TKTonKho);
                }
                var lst = _lstTonKhos.OrderBy(c => c.TenSp).GroupBy(c => c.TenSp)
                    .Select(g => new ThongkentonkhoViewModel(g.Key, g.Sum(c => c.SoLuongTon))).ToList();
                return lst;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
