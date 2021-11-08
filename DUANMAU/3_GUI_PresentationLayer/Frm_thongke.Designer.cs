
namespace _3_GUI_PresentationLayer
{
    partial class Frm_thongke
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.thongke_nhapkho = new System.Windows.Forms.TabPage();
            this.dtgview_nhapkho = new System.Windows.Forms.DataGridView();
            this.thongke_tonkho = new System.Windows.Forms.TabPage();
            this.dtgview_tonkho = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.thongke_nhapkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_nhapkho)).BeginInit();
            this.thongke_tonkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_tonkho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.thongke_nhapkho);
            this.tabControl1.Controls.Add(this.thongke_tonkho);
            this.tabControl1.Location = new System.Drawing.Point(-3, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 216);
            this.tabControl1.TabIndex = 0;
            // 
            // thongke_nhapkho
            // 
            this.thongke_nhapkho.Controls.Add(this.dtgview_nhapkho);
            this.thongke_nhapkho.Location = new System.Drawing.Point(4, 24);
            this.thongke_nhapkho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.thongke_nhapkho.Name = "thongke_nhapkho";
            this.thongke_nhapkho.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.thongke_nhapkho.Size = new System.Drawing.Size(806, 188);
            this.thongke_nhapkho.TabIndex = 0;
            this.thongke_nhapkho.Text = "Sản phẩm nhập kho";
            this.thongke_nhapkho.UseVisualStyleBackColor = true;
            // 
            // dtgview_nhapkho
            // 
            this.dtgview_nhapkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview_nhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview_nhapkho.Location = new System.Drawing.Point(10, 11);
            this.dtgview_nhapkho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgview_nhapkho.Name = "dtgview_nhapkho";
            this.dtgview_nhapkho.RowHeadersWidth = 82;
            this.dtgview_nhapkho.RowTemplate.Height = 41;
            this.dtgview_nhapkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgview_nhapkho.Size = new System.Drawing.Size(792, 175);
            this.dtgview_nhapkho.TabIndex = 0;
            // 
            // thongke_tonkho
            // 
            this.thongke_tonkho.Controls.Add(this.dtgview_tonkho);
            this.thongke_tonkho.Location = new System.Drawing.Point(4, 24);
            this.thongke_tonkho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.thongke_tonkho.Name = "thongke_tonkho";
            this.thongke_tonkho.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.thongke_tonkho.Size = new System.Drawing.Size(683, 256);
            this.thongke_tonkho.TabIndex = 1;
            this.thongke_tonkho.Text = "Sản phẩm tồn kho";
            this.thongke_tonkho.UseVisualStyleBackColor = true;
            // 
            // dtgview_tonkho
            // 
            this.dtgview_tonkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview_tonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview_tonkho.Location = new System.Drawing.Point(2, 21);
            this.dtgview_tonkho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgview_tonkho.Name = "dtgview_tonkho";
            this.dtgview_tonkho.RowHeadersWidth = 82;
            this.dtgview_tonkho.RowTemplate.Height = 41;
            this.dtgview_tonkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgview_tonkho.Size = new System.Drawing.Size(678, 241);
            this.dtgview_tonkho.TabIndex = 0;
            // 
            // Frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 255);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Frm_thongke";
            this.Text = "Frm_thongke";
            this.tabControl1.ResumeLayout(false);
            this.thongke_nhapkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_nhapkho)).EndInit();
            this.thongke_tonkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_tonkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage thongke_nhapkho;
        private System.Windows.Forms.DataGridView dtgview_nhapkho;
        private System.Windows.Forms.TabPage thongke_tonkho;
        private System.Windows.Forms.DataGridView dtgview_tonkho;
    }
}