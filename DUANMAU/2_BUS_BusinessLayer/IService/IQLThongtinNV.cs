using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IQLThongtinNV
    {
        string updatePassword(string email,string mkcu, string mkmoi);

        bool checkmkcu(string mkcu, string email);
    }
}
