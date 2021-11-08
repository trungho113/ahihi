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




namespace _3_GUI_PresentationLayer
{
    public partial class FrmMain : Form
    {
        private Frm_Login Frm_Login;
        ILoginService _LoginService;
        public static int session=0; //kiểm tra tình trạng login
        public static int profile = 0;
        public static string ten;//truyền email từ frmmain cho các form khách thông qua biến static
        public static int checkLan1DN = 0;
        public static int vaitro = 0;
        private Frm_NhanVien frm_NhanVien;
        private Frm_QLThongTinNV frm_QLThongTinNV;
        private Frm_Product frm_Product;
        private Frm_KhachHang frm_KhachHang;
        private Frm_thongke frm_Thongke;
        private LoginViewModel _LoginViewModel;
        public FrmMain()
        {
            InitializeComponent();
            _LoginService = new LoginService();      

        }

        private void menu_dangnhap_Click(object sender, EventArgs e)
        {
           
            Frm_Login = new Frm_Login();
            Frm_Login.Show();
            Frm_Login.Location = new Point(700, 300);

        }

        private void menu_huongdanphanmem_Click(object sender, EventArgs e)
        {
           
            _LoginService.openfile("SOF205_Lab guide.pdf"); 
        }


        //kiểm tra form đã hiển thị chưa
     
        public  void FrmMain_Load(object sender, EventArgs e)
        {
            resetvalue();
          //this.TopMost = true;//màn hình luôn nằm trên
          //  this.FormBorderStyle = FormBorderStyle.None;//không có phóng to thu nhỏ
            this.WindowState = FormWindowState.Maximized;
            if (profile==1)//nếu vừa mới cập nhật mật khẩu thì phải login lại mục "Thông tin nhân viên" ẩn
            {
             
                profile = 0; //ẩn mục thông tin nhân viên
            }
        }


        private void vaitroNV()
        {
            menu_nhanvien.Visible = false;
            menu_thongke.Visible = false;
        }
        public  void resetvalue()
        {
            if (session==1)
            {
                lbl_chao.Show();
                lbl_chao.Text = " " + FrmMain.ten;
                lbl_chao.TextAlign = ContentAlignment.TopRight;
                menu_nhanvien.Visible = true;
                menu_khachhang.Visible = true;
                menu_sanpham.Visible = true;
                Menu_thongtin.Visible = true;
                menu_danhmuc.Visible = true;
                menu_thongke.Visible = true;
                menu_dangnhap.Enabled = false;
                menu_dangxuat.Enabled = true;
                
                if ((Frm_Login.vaitro)== false)
                {
                    vaitroNV();
                }
            }
            else
            {
                menu_dangnhap.Enabled = true;
                menu_nhanvien.Visible = false;
                menu_khachhang.Visible = false;
                menu_sanpham.Visible = false;
                Menu_thongtin.Visible = false;
                lbl_chao.Text = null;
                lbl_chao.Hide();
                menu_danhmuc.Visible = false;
                menu_thongke.Visible = false;
                menu_dangxuat.Enabled = false;
            }
        }

        private void menu_nhanvien_Click(object sender, EventArgs e)
        {
            frm_NhanVien = new Frm_NhanVien();
            frm_NhanVien.Show();
            frm_NhanVien.Location = new Point(700, 300);
        }

        private void Menu_thongtin_Click(object sender, EventArgs e)
        {
            frm_QLThongTinNV = new Frm_QLThongTinNV();
            frm_QLThongTinNV.Show();
            frm_QLThongTinNV.Location = new Point(700, 300);
        }

        private void menu_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_khachhang_Click(object sender, EventArgs e)
        {
            frm_KhachHang = new Frm_KhachHang();
            frm_KhachHang.Show();
            frm_KhachHang.Location = new Point(700, 300);
        }

        private void menu_sanpham_Click(object sender, EventArgs e)
        {
            frm_Product = new Frm_Product();
            frm_Product.Show();
            frm_Product.Location = new Point(700, 300);
        }

        private void menu_thongkesp_Click(object sender, EventArgs e)
        {
            frm_Thongke = new Frm_thongke();
            frm_Thongke.Show();
            frm_Thongke.Location = new Point(700, 300);
        }

        private void menu_dangxuat_Click(object sender, EventArgs e)
        {
            session = 0;
            resetvalue();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            FrmMain_Load(sender, e);
        }

        private void FrmMain_MouseHover(object sender, EventArgs e)
        {
            FrmMain_Load(sender, e);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            FrmMain_Load(sender, e);
        }

    
    }
}
