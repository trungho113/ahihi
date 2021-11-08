using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.DALService;

namespace _1_DAL_DataAccessLayer.IDALService
{
   public interface IHangService
    {
        string add(Hang hang);
        string update(Hang hang);
        string delete(string mahang);
        List<Hang> GetlstHang();
        void GetlstHangFromDB();

    }
}
