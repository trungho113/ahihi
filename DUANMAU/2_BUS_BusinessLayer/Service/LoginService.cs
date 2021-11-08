using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.DALService;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using _1_DAL_DataAccessLayer.Models;
using System.Diagnostics;
using System.IO;

namespace _2_BUS_BusinessLayer.Service
{
    public class LoginService : ILoginService
    {
        private INhanVienService _INhanvienService;
        private string to;
        public LoginService()
        {
            _INhanvienService = new NhanVienService();
        }
        public bool dangnhap(string email, string matkhau)
        {
            if (_INhanvienService.getlstNhanVien().Any(c => c.Email == email && c.Matkhau == matkhau))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string encryption(string passwokd)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passwokd);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public bool quenmatkhau(string email)
        {
            var check = _INhanvienService.getlstNhanVien().Any(c => c.Email == email);
           
            return check;
        }


        public string taomatkhaumoi(string email,string matkhau)
        {
          
            var check = _INhanvienService.getlstNhanVien().FirstOrDefault(c => c.Email ==email );
            check.Matkhau = matkhau;
            return _INhanvienService.update(check);
        }
        public string RamdomString(int size,bool lowercase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowercase)
            {
                return builder.ToString().ToLower();
            }
            return null;
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string Sendmail(string email, string matkhau)
        {      
            string  from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = (email).ToString();
            from = "trunghtph13733@fpt.edu.vn";
            pass = "17082002";
            messageBody = "Mật khẩu của bạn là : " + matkhau;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Cung cấp mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                return "yêu cầu kiểm tra mail";
            }
            catch (Exception )
            {  
            }
            return "Gửi mail thất bại";
        }
        //lấy file hướng đẫn phần mềm
        public bool openfile (string file)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), file);
                Process.Start(path);
                return true;
            }
            catch (Exception)
            {
            }
            return false;      
        }
        public bool nhotk(string email, string matkhau)
        {
            throw new NotImplementedException();
        }
    }
}
