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
    public class QLSANPHAMService : IQLSANPHAMService
    {
        private List<SanPhamViewModel> _lstSPModel;
        IHangService _hangService;
        private List<Hang> _lsthangs;

        public QLSANPHAMService()
        {
            _hangService = new HangService();
            _lsthangs = _hangService.GetlstHang();
            _lstSPModel = new List<SanPhamViewModel>();
        }
        public string add(Hang hang)
        {
            return _hangService.add(hang);
        }
        public string delete(string tenhang)
        {
            return _hangService.delete(tenhang);
        }
        public List<Hang> loadhang()
        {
            return _hangService.GetlstHang();
        }
        public string update(Hang hang)
        {
            return _hangService.update(hang);
        }
    }
}
