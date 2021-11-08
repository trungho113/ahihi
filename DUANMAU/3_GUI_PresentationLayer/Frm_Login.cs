using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;
using System.Net;
using System.Net.Mail;


namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Login : Form
    {

        private ILoginService _loginService;
        private IQLNVService _QLNVService;
        private LoginViewModel _LoginViewModel;
        public static bool vaitro;
        private Validateform _validateform;
        public Frm_Login()
        {
            InitializeComponent();
            _loginService = new LoginService();
            _QLNVService = new QlNVService();
            _LoginViewModel = new LoginViewModel();
            _validateform = new Validateform();
        }

        private bool checkloi()
        {
            if (_validateform.checkNull(tbx_email.Text) || _validateform.checkNull(tbx_matkhau.Text))
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo");
                return true;
            }
            return false;
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

            if (checkloi()) return;
            if (_loginService.dangnhap(tbx_email.Text, _loginService.encryption(tbx_matkhau.Text)))
            {
                MessageBox.Show("Đăng nhập thành công");
                var ten = _QLNVService.loadnv().Where(c => c.Email == tbx_email.Text).Select(c => c.Tennv).FirstOrDefault();
                var nvvaitro = _QLNVService.loadnv().Where(c => c.Email == tbx_email.Text).Select(c => c.Vaitro).FirstOrDefault();
                string mail = _QLNVService.loadnv().Where(c => c.Email == tbx_email.Text).Select(c => c.Email).FirstOrDefault();
                var manv = _QLNVService.loadnv().Where(c => c.Email == tbx_email.Text).Select(c => c.Manv).FirstOrDefault();
                Frm_QLThongTinNV.mail = mail;
                Frm_KhachHang.manv = manv;
                Frm_Product._manv = manv;
                FrmMain.ten = ten;//truyền email đăng nhập cho frm_main
                vaitro = _LoginViewModel.vaitro = nvvaitro;
                FrmMain.session = 1;//cập nhật trạng thái đăng nhập thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, kiểm tra lại email hoặc mật khẩu");
                tbx_email.Text = null;
                tbx_matkhau.Text = null;
                tbx_email.Focus();
            }


        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_quenmk_Click(object sender, EventArgs e)
        {
            if (_loginService.quenmatkhau(tbx_email.Text))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(_loginService.RamdomString(4, true));
                stringBuilder.Append(_loginService.RandomNumber(1000, 9999));
                stringBuilder.Append(_loginService.RamdomString(2, false));
                string matkhaumoi = _loginService.encryption(stringBuilder.ToString());//cập nhật mật khẩu và mã hóa
                _loginService.taomatkhaumoi(tbx_email.Text, matkhaumoi);//update passwork database 
                MessageBox.Show(_loginService.Sendmail(tbx_email.Text, stringBuilder.ToString()), "Thông báo");
            }
            else
            {
                MessageBox.Show("Email bạn điền không chính xác", "Thông báo");
                tbx_email.Text = "";
            }
        }

        

        
    }
}
