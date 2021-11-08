using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IQLSANPHAMService
    {
        string add(Hang hang);
        string update(Hang hang);
        string delete(string tenhang);
        List<Hang> loadhang();
    }
}
