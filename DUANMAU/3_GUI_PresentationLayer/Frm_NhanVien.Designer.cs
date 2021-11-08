
namespace _3_GUI_PresentationLayer
{
    partial class Frm_NhanVien
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_ds = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_tk = new System.Windows.Forms.TextBox();
            this.tbx_tennv = new System.Windows.Forms.TextBox();
            this.dtgview_nhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_diachi = new System.Windows.Forms.RichTextBox();
            this.rbx_nv = new System.Windows.Forms.RadioButton();
            this.rbx_quantri = new System.Windows.Forms.RadioButton();
            this.rbx_hd = new System.Windows.Forms.RadioButton();
            this.rbx_khd = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_MaNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(351, 364);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Location = new System.Drawing.Point(438, 364);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Enabled = false;
            this.btn_sua.Location = new System.Drawing.Point(519, 364);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(601, 364);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(682, 364);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 23);
            this.btn_boqua.TabIndex = 4;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_ds
            // 
            this.btn_ds.Location = new System.Drawing.Point(763, 364);
            this.btn_ds.Name = "btn_ds";
            this.btn_ds.Size = new System.Drawing.Size(75, 23);
            this.btn_ds.TabIndex = 5;
            this.btn_ds.Text = "Danh sách";
            this.btn_ds.UseVisualStyleBackColor = true;
            this.btn_ds.Click += new System.EventHandler(this.btn_ds_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(844, 364);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 6;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(213, 327);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 7;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tbx_email
            // 
            this.tbx_email.Enabled = false;
            this.tbx_email.Location = new System.Drawing.Point(98, 48);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(164, 23);
            this.tbx_email.TabIndex = 8;
            // 
            // tbx_tk
            // 
            this.tbx_tk.Location = new System.Drawing.Point(24, 327);
            this.tbx_tk.Name = "tbx_tk";
            this.tbx_tk.Size = new System.Drawing.Size(183, 23);
            this.tbx_tk.TabIndex = 9;
            this.tbx_tk.Click += new System.EventHandler(this.tbx_tk_Click);
            // 
            // tbx_tennv
            // 
            this.tbx_tennv.Enabled = false;
            this.tbx_tennv.Location = new System.Drawing.Point(98, 94);
            this.tbx_tennv.Name = "tbx_tennv";
            this.tbx_tennv.Size = new System.Drawing.Size(164, 23);
            this.tbx_tennv.TabIndex = 11;
            // 
            // dtgview_nhanvien
            // 
            this.dtgview_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview_nhanvien.Location = new System.Drawing.Point(24, 171);
            this.dtgview_nhanvien.Name = "dtgview_nhanvien";
            this.dtgview_nhanvien.RowHeadersWidth = 82;
            this.dtgview_nhanvien.RowTemplate.Height = 25;
            this.dtgview_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgview_nhanvien.Size = new System.Drawing.Size(895, 150);
            this.dtgview_nhanvien.TabIndex = 12;
            this.dtgview_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgview_nhanvien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa chỉ";
            // 
            // rtb_diachi
            // 
            this.rtb_diachi.Enabled = false;
            this.rtb_diachi.Location = new System.Drawing.Point(355, 48);
            this.rtb_diachi.Name = "rtb_diachi";
            this.rtb_diachi.Size = new System.Drawing.Size(313, 23);
            this.rtb_diachi.TabIndex = 22;
            this.rtb_diachi.Text = "";
            // 
            // rbx_nv
            // 
            this.rbx_nv.AutoSize = true;
            this.rbx_nv.Location = new System.Drawing.Point(14, 24);
            this.rbx_nv.Name = "rbx_nv";
            this.rbx_nv.Size = new System.Drawing.Size(79, 19);
            this.rbx_nv.TabIndex = 23;
            this.rbx_nv.TabStop = true;
            this.rbx_nv.Text = "Nhân viên";
            this.rbx_nv.UseVisualStyleBackColor = true;
            // 
            // rbx_quantri
            // 
            this.rbx_quantri.AutoSize = true;
            this.rbx_quantri.Location = new System.Drawing.Point(114, 24);
            this.rbx_quantri.Name = "rbx_quantri";
            this.rbx_quantri.Size = new System.Drawing.Size(68, 19);
            this.rbx_quantri.TabIndex = 24;
            this.rbx_quantri.TabStop = true;
            this.rbx_quantri.Text = "Quản trị";
            this.rbx_quantri.UseVisualStyleBackColor = true;
            // 
            // rbx_hd
            // 
            this.rbx_hd.AutoSize = true;
            this.rbx_hd.Location = new System.Drawing.Point(13, 20);
            this.rbx_hd.Name = "rbx_hd";
            this.rbx_hd.Size = new System.Drawing.Size(82, 19);
            this.rbx_hd.TabIndex = 25;
            this.rbx_hd.TabStop = true;
            this.rbx_hd.Text = "Hoạt động";
            this.rbx_hd.UseVisualStyleBackColor = true;
            // 
            // rbx_khd
            // 
            this.rbx_khd.AutoSize = true;
            this.rbx_khd.Location = new System.Drawing.Point(101, 20);
            this.rbx_khd.Name = "rbx_khd";
            this.rbx_khd.Size = new System.Drawing.Size(118, 19);
            this.rbx_khd.TabIndex = 26;
            this.rbx_khd.TabStop = true;
            this.rbx_khd.Text = "Không hoạt động";
            this.rbx_khd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbx_quantri);
            this.groupBox1.Controls.Add(this.rbx_nv);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(306, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(215, 46);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vai trò";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbx_hd);
            this.groupBox2.Controls.Add(this.rbx_khd);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(553, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(231, 46);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mã NV";
            // 
            // tbx_MaNV
            // 
            this.tbx_MaNV.Enabled = false;
            this.tbx_MaNV.Location = new System.Drawing.Point(98, 136);
            this.tbx_MaNV.Name = "tbx_MaNV";
            this.tbx_MaNV.Size = new System.Drawing.Size(164, 23);
            this.tbx_MaNV.TabIndex = 32;
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 426);
            this.Controls.Add(this.tbx_MaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_diachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgview_nhanvien);
            this.Controls.Add(this.tbx_tennv);
            this.Controls.Add(this.tbx_tk);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_ds);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_them;
    private System.Windows.Forms.Button btn_xoa;
    private System.Windows.Forms.Button btn_sua;
    private System.Windows.Forms.Button btn_luu;
    private System.Windows.Forms.Button btn_boqua;
    private System.Windows.Forms.Button btn_ds;
    private System.Windows.Forms.Button btn_dong;
    private System.Windows.Forms.Button btn_timkiem;
    private System.Windows.Forms.TextBox tbx_email;
    private System.Windows.Forms.TextBox tbx_tk;
    private System.Windows.Forms.TextBox tbx_tennv;
    private System.Windows.Forms.DataGridView dtgview_nhanvien;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox rtb_diachi;
    private System.Windows.Forms.RadioButton rbx_nv;
    private System.Windows.Forms.RadioButton rbx_quantri;
    private System.Windows.Forms.RadioButton rbx_hd;
    private System.Windows.Forms.RadioButton rbx_khd;
    private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_MaNV;
    }
}