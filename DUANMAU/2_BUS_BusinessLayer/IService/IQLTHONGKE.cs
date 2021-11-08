using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2_BUS_BusinessLayer.IService
{
   public  interface IQLTHONGKE
    {
        List<ThongkentonkhoViewModel> viewSPTonKhos();
        List<ThongkennhapkhoViewModel> viewNhapKhos();
    }
}
