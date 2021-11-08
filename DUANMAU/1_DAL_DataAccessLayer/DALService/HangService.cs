using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class HangService : IHangService
    {
        private List<Hang> _lsthang;
        private DatabaseContext _DatabaseContext;
        public HangService()
        {
            _lsthang = new List<Hang>();
            _DatabaseContext = new DatabaseContext();
            GetlstHangFromDB();
        }
        public string add(Hang hang)
        {
            _DatabaseContext.Hangs.Add(hang);
            _DatabaseContext.SaveChanges();
            GetlstHangFromDB();
            return "Thêm thành công";
        }

        public string delete(string mahang)
        {
            var acc = GetlstHang().FirstOrDefault(c => c.Mahang == mahang);
            _DatabaseContext.Hangs.Remove(acc);
            _DatabaseContext.SaveChanges();
            GetlstHangFromDB();
            return "Xóa thành công";
        }

        public List<Hang> GetlstHang()
        {
            return _lsthang;
        }

        public void GetlstHangFromDB()
        {
            _lsthang = _DatabaseContext.Hangs.ToList();
        }

        public string update(Hang hang)
        {
            _DatabaseContext.Hangs.Update(hang);
            _DatabaseContext.SaveChanges();
            GetlstHangFromDB();
            return "Sửa thành công";
        }
    }
}
