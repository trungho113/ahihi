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
using _2_BUS_BusinessLayer.Utilities;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_QLThongTinNV : Form
    {
       private IQLThongtinNV _thongtinNV;
       private ILoginService _LoginService;
        public static string mail;
        private Validateform _validateform;
        public Frm_QLThongTinNV()
        {
            InitializeComponent();
            _thongtinNV = new QLThongtinNV();
            _LoginService = new LoginService();
            _validateform = new Validateform();
        }

        private void Frm_QLThongTinNV_Load(object sender, EventArgs e)
        {
            tbx_email.Text = mail;
            tbx_email.Enabled = false;
        }

        private bool checkloi()
        {
            if (_validateform.checkNull(tbx_mkcu.Text) || _validateform.checkNull(tbx_mkmoi.Text) || _validateform.checkNull(tbx_nhaplaimkmoi.Text))
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo");
                return true;
            }
            return false;
        }
        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn thay đổi không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tbx_mkmoi.Text == tbx_nhaplaimkmoi.Text)
                {

                    MessageBox.Show(_thongtinNV.updatePassword(tbx_email.Text, _LoginService.encryption(tbx_mkcu.Text), _LoginService.encryption(tbx_nhaplaimkmoi.Text)));
                    if (_thongtinNV.checkmkcu(tbx_mkcu.Text, tbx_email.Text)==false) return;
                    _LoginService.Sendmail(tbx_email.Text, tbx_nhaplaimkmoi.Text);
                    FrmMain.profile = 1;//cập nhật pass word thành công
                    FrmMain.session = 0;//đưa về tình trạng chưa đăng nhập
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp");
                    tbx_mkcu.Text = null;
                    tbx_mkmoi.Text = null;
                    tbx_nhaplaimkmoi.Text = null;
                    tbx_mkcu.Focus();
                } 
            }
         
        }
    }
}
