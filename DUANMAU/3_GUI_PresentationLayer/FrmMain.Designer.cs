
namespace _3_GUI_PresentationLayer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongkesp = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_huongdansudung = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_gioithieuphanmem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_chao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_hethong,
            this.menu_danhmuc,
            this.menu_thongke,
            this.menu_huongdan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_hethong
            // 
            this.menu_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dangnhap,
            this.menu_dangxuat,
            this.menu_thoat,
            this.Menu_thongtin});
            this.menu_hethong.Name = "menu_hethong";
            this.menu_hethong.Size = new System.Drawing.Size(69, 22);
            this.menu_hethong.Text = "Hệ thống";
            // 
            // menu_dangnhap
            // 
            this.menu_dangnhap.Image = global::_3_GUI_PresentationLayer.Properties.Resources.avt_cute;
            this.menu_dangnhap.Name = "menu_dangnhap";
            this.menu_dangnhap.Size = new System.Drawing.Size(196, 38);
            this.menu_dangnhap.Text = "Đăng nhập";
            this.menu_dangnhap.Click += new System.EventHandler(this.menu_dangnhap_Click);
            // 
            // menu_dangxuat
            // 
            this.menu_dangxuat.Enabled = false;
            this.menu_dangxuat.Image = global::_3_GUI_PresentationLayer.Properties.Resources.FB_IMG_15966020260441;
            this.menu_dangxuat.Name = "menu_dangxuat";
            this.menu_dangxuat.Size = new System.Drawing.Size(196, 38);
            this.menu_dangxuat.Text = "Đăng xuất";
            this.menu_dangxuat.Click += new System.EventHandler(this.menu_dangxuat_Click);
            // 
            // menu_thoat
            // 
            this.menu_thoat.Image = global::_3_GUI_PresentationLayer.Properties.Resources._3bffb706ab4b3432133fe5b058fde14c;
            this.menu_thoat.Name = "menu_thoat";
            this.menu_thoat.Size = new System.Drawing.Size(196, 38);
            this.menu_thoat.Text = "Thoát";
            this.menu_thoat.Click += new System.EventHandler(this.menu_thoat_Click);
            // 
            // Menu_thongtin
            // 
            this.Menu_thongtin.Image = global::_3_GUI_PresentationLayer.Properties.Resources._96358PIC8025bV6Dc6Xa58PIC_PIC2018_png_860;
            this.Menu_thongtin.Name = "Menu_thongtin";
            this.Menu_thongtin.Size = new System.Drawing.Size(196, 38);
            this.Menu_thongtin.Text = "Thông tin nhân viên";
            this.Menu_thongtin.Click += new System.EventHandler(this.Menu_thongtin_Click);
            // 
            // menu_danhmuc
            // 
            this.menu_danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sanpham,
            this.menu_nhanvien,
            this.menu_khachhang});
            this.menu_danhmuc.Name = "menu_danhmuc";
            this.menu_danhmuc.Size = new System.Drawing.Size(74, 22);
            this.menu_danhmuc.Text = "Danh mục";
            // 
            // menu_sanpham
            // 
            this.menu_sanpham.Image = global::_3_GUI_PresentationLayer.Properties.Resources.fccc80457189734922893b057f1f83f71;
            this.menu_sanpham.Name = "menu_sanpham";
            this.menu_sanpham.Size = new System.Drawing.Size(196, 38);
            this.menu_sanpham.Text = "Sản phẩm ";
            this.menu_sanpham.Click += new System.EventHandler(this.menu_sanpham_Click);
            // 
            // menu_nhanvien
            // 
            this.menu_nhanvien.Image = global::_3_GUI_PresentationLayer.Properties.Resources.FB_IMG_1595336735810;
            this.menu_nhanvien.Name = "menu_nhanvien";
            this.menu_nhanvien.Size = new System.Drawing.Size(196, 38);
            this.menu_nhanvien.Text = "Nhân viên";
            this.menu_nhanvien.Click += new System.EventHandler(this.menu_nhanvien_Click);
            // 
            // menu_khachhang
            // 
            this.menu_khachhang.Image = global::_3_GUI_PresentationLayer.Properties.Resources.received_710329632837096;
            this.menu_khachhang.Name = "menu_khachhang";
            this.menu_khachhang.Size = new System.Drawing.Size(196, 38);
            this.menu_khachhang.Text = "Khách hàng";
            this.menu_khachhang.Click += new System.EventHandler(this.menu_khachhang_Click);
            // 
            // menu_thongke
            // 
            this.menu_thongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_thongkesp});
            this.menu_thongke.Name = "menu_thongke";
            this.menu_thongke.Size = new System.Drawing.Size(68, 22);
            this.menu_thongke.Text = "Thống kê";
            // 
            // menu_thongkesp
            // 
            this.menu_thongkesp.Image = global::_3_GUI_PresentationLayer.Properties.Resources.FB_IMG_1585217171163;
            this.menu_thongkesp.Name = "menu_thongkesp";
            this.menu_thongkesp.Size = new System.Drawing.Size(197, 38);
            this.menu_thongkesp.Text = "Thống kê  sản phẩm";
            this.menu_thongkesp.Click += new System.EventHandler(this.menu_thongkesp_Click);
            // 
            // menu_huongdan
            // 
            this.menu_huongdan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_huongdansudung,
            this.menu_gioithieuphanmem});
            this.menu_huongdan.Name = "menu_huongdan";
            this.menu_huongdan.Size = new System.Drawing.Size(82, 22);
            this.menu_huongdan.Text = "Hướng dẫn ";
            // 
            // menu_huongdansudung
            // 
            this.menu_huongdansudung.Image = global::_3_GUI_PresentationLayer.Properties.Resources.Card_file1;
            this.menu_huongdansudung.Name = "menu_huongdansudung";
            this.menu_huongdansudung.Size = new System.Drawing.Size(202, 38);
            this.menu_huongdansudung.Text = "Hướng dẫn sử dụng";
            this.menu_huongdansudung.Click += new System.EventHandler(this.menu_huongdanphanmem_Click);
            // 
            // menu_gioithieuphanmem
            // 
            this.menu_gioithieuphanmem.Image = global::_3_GUI_PresentationLayer.Properties.Resources.Clipboard;
            this.menu_gioithieuphanmem.Name = "menu_gioithieuphanmem";
            this.menu_gioithieuphanmem.Size = new System.Drawing.Size(202, 38);
            this.menu_gioithieuphanmem.Text = "Giới thiệu phần mềm";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(245, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 136);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dự án mẫu C# - Quản Lý Bán Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = global::_3_GUI_PresentationLayer.Properties.Resources.Bieu_tuong_fpoly;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(121, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(733, 432);
            this.label2.TabIndex = 2;
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // lbl_chao
            // 
            this.lbl_chao.AutoSize = true;
            this.lbl_chao.Location = new System.Drawing.Point(756, 4);
            this.lbl_chao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_chao.Name = "lbl_chao";
            this.lbl_chao.Size = new System.Drawing.Size(35, 15);
            this.lbl_chao.TabIndex = 3;
            this.lbl_chao.Text = "Chào";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 504);
            this.Controls.Add(this.lbl_chao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseHover += new System.EventHandler(this.FrmMain_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_hethong;
        private System.Windows.Forms.ToolStripMenuItem menu_dangnhap;
        private System.Windows.Forms.ToolStripMenuItem menu_dangxuat;
        private System.Windows.Forms.ToolStripMenuItem menu_thoat;
        private System.Windows.Forms.ToolStripMenuItem menu_danhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem Menu_thongtin;
        private System.Windows.Forms.ToolStripMenuItem menu_sanpham;
        private System.Windows.Forms.ToolStripMenuItem menu_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem menu_khachhang;
        private System.Windows.Forms.ToolStripMenuItem menu_thongke;
        private System.Windows.Forms.ToolStripMenuItem menu_thongkesp;
        private System.Windows.Forms.ToolStripMenuItem menu_huongdan;
        private System.Windows.Forms.ToolStripMenuItem menu_huongdansudung;
        private System.Windows.Forms.ToolStripMenuItem menu_gioithieuphanmem;
        private System.Windows.Forms.Label lbl_chao;
    }
}