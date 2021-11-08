
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_quenmk = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_matkhau = new System.Windows.Forms.TextBox();
            this.cbx_nhotk = new System.Windows.Forms.CheckBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập hệ thống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // lbl_quenmk
            // 
            this.lbl_quenmk.AutoSize = true;
            this.lbl_quenmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_quenmk.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_quenmk.Location = new System.Drawing.Point(240, 191);
            this.lbl_quenmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_quenmk.Name = "lbl_quenmk";
            this.lbl_quenmk.Size = new System.Drawing.Size(97, 15);
            this.lbl_quenmk.TabIndex = 5;
            this.lbl_quenmk.Text = "Quên mật khẩu ?";
            this.lbl_quenmk.Click += new System.EventHandler(this.lbl_quenmk_Click);
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(75, 108);
            this.tbx_email.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(262, 23);
            this.tbx_email.TabIndex = 6;
            this.tbx_email.Text = "trunghtph13733@fpt.edu.vn";
            // 
            // tbx_matkhau
            // 
            this.tbx_matkhau.Location = new System.Drawing.Point(75, 161);
            this.tbx_matkhau.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbx_matkhau.Name = "tbx_matkhau";
            this.tbx_matkhau.Size = new System.Drawing.Size(262, 23);
            this.tbx_matkhau.TabIndex = 7;
            // 
            // cbx_nhotk
            // 
            this.cbx_nhotk.AutoSize = true;
            this.cbx_nhotk.Location = new System.Drawing.Point(75, 191);
            this.cbx_nhotk.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbx_nhotk.Name = "cbx_nhotk";
            this.cbx_nhotk.Size = new System.Drawing.Size(101, 19);
            this.cbx_nhotk.TabIndex = 8;
            this.cbx_nhotk.Text = "Nhớ tài khoản";
            this.cbx_nhotk.UseVisualStyleBackColor = true;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dangnhap.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dangnhap.Location = new System.Drawing.Point(211, 246);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(106, 24);
            this.btn_dangnhap.TabIndex = 9;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.ForeColor = System.Drawing.Color.Transparent;
            this.btn_thoat.Location = new System.Drawing.Point(95, 245);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 24);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 296);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.cbx_nhotk);
            this.Controls.Add(this.tbx_matkhau);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.lbl_quenmk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_quenmk;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_matkhau;
        private System.Windows.Forms.CheckBox cbx_nhotk;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
    }
}

