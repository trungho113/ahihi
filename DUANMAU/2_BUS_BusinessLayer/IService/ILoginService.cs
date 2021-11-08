using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IService
{
  public interface ILoginService
    {
        string encryption(string passwokd);
        bool dangnhap(string email,string matkhau);
        bool quenmatkhau(string email);
        string RamdomString(int size, bool lowercase);
        int RandomNumber(int min, int max);
        string Sendmail(string email, string matkhau);
        string taomatkhaumoi(string email, string matkhau);
        bool openfile(string file);
        bool nhotk(string email, string matkhau);

    }
}
