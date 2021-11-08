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
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_NhanVien : Form
    {
        private IQLNVService BUS_QLNV;
        private string _emailvWhenclick;
        private ILoginService _LoginService;
        private NhanVienViewModel _NhanVienViewModel;
        private Validateform _Validateform;
        public Frm_NhanVien()
        {
            InitializeComponent();
            BUS_QLNV = new QlNVService();
            loadata();
            _NhanVienViewModel = new NhanVienViewModel();
            _LoginService = new LoginService();
            _Validateform = new Validateform();
        }


        void loadata()
        {
            dtgview_nhanvien.ColumnCount = 5;

            dtgview_nhanvien.Columns[0].HeaderText = "Email";
            dtgview_nhanvien.Columns[1].HeaderText = "Tên Nhân Viên";
            dtgview_nhanvien.Columns[2].HeaderText = "Địa chỉ";
            dtgview_nhanvien.Columns[3].HeaderText = "Vai trò";
            dtgview_nhanvien.Columns[4].HeaderText = "Tình trạng";

            dtgview_nhanvien.Rows.Clear();
            foreach (var x in BUS_QLNV.loadnv())
            {
                dtgview_nhanvien.Rows.Add(x.Email, x.Tennv, x.Diachi, x.Vaitro == true ? "Quản trị" : "Nhân viên", x.Tinhtrang == true ? "Hoạt động" : "Ngừng hoạt động");
            }

        }
        void loadata(string ten)
        {
            dtgview_nhanvien.ColumnCount = 5;

            dtgview_nhanvien.Columns[0].HeaderText = "Email";
            dtgview_nhanvien.Columns[1].HeaderText = "Tên Nhân Viên";
            dtgview_nhanvien.Columns[2].HeaderText = "Địa chỉ";
            dtgview_nhanvien.Columns[3].HeaderText = "Vai trò";
            dtgview_nhanvien.Columns[4].HeaderText = "Tình trạng";

            dtgview_nhanvien.Rows.Clear();
            foreach (var x in BUS_QLNV.timkiem(ten))
            {
                dtgview_nhanvien.Rows.Add(x.Email, x.Tennv, x.Diachi, x.Vaitro == true ? "Quản trị" : "Nhân viên", x.Tinhtrang == true ? "Hoạt động" : "Ngừng hoạt động");
            }

        }

        public bool checkloi()
        {
            if (_Validateform.checkNull(tbx_email.Text) || _Validateform.checkNull(tbx_tennv.Text) || _Validateform.checkNull(rtb_diachi.Text))
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo");
                return true;
            }
            if (_Validateform.checkEmail(tbx_email.Text))
            {
                MessageBox.Show("Mời bạn nhập định dạng Email", "Thông báo");
                return true;

            }
            if (_Validateform.checkChu(tbx_tennv.Text))
            {
                MessageBox.Show("Tên phải nhập bằng chữ", "Thông báo");
                return true;

            }
            if (rbx_nv.Checked == false && rbx_quantri.Checked == false)
            {
                MessageBox.Show("yêu cầu bạn chọn quyền", "Thông báo");
                return true;

            }
            if (rbx_hd.Checked == false && rbx_khd.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn trạng thái", "Thông báo");
                return true;

            }

            return false;


        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            tbx_email.Text = null;
            tbx_tennv.Text = null;
            tbx_MaNV.Text = null;
            tbx_MaNV.Enabled = true;
            rtb_diachi.Text = null;
            rbx_quantri.Checked = false;
            rbx_nv.Checked = false;
            rbx_hd.Checked = false;
            rbx_khd.Checked = false;
            tbx_email.Enabled = true;
            tbx_tennv.Enabled = true;
            rtb_diachi.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //  if( MessageBox.Show(BUS_QLNV.checkloi(tbx_email.Text, tbx_tennv.Text, rtb_diachi.Text,rbx_quantri.Checked,rbx_nv.Checked,rbx_hd.Checked,rbx_khd.Checked), "Thông báo")==true)
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn thêm không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Nhanvien nhanvien = new Nhanvien();
                nhanvien.Email = tbx_email.Text;
                nhanvien.Tennv = tbx_tennv.Text;
                nhanvien.Manv = tbx_MaNV.Text;
                nhanvien.Diachi = rtb_diachi.Text;
                nhanvien.Vaitro = rbx_quantri.Checked;
                nhanvien.Tinhtrang = rbx_hd.Checked;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(_LoginService.RamdomString(4, true));
                stringBuilder.Append(_LoginService.RandomNumber(1000, 9999));
                stringBuilder.Append(_LoginService.RamdomString(2, false));
                string matkhau = _LoginService.encryption(stringBuilder.ToString());
                nhanvien.Matkhau = matkhau;
                MessageBox.Show(BUS_QLNV.add(nhanvien), "Thông báo");
                MessageBox.Show(_LoginService.Sendmail(tbx_email.Text, stringBuilder.ToString()), "Thông báo");
                tbx_email.Text = null;
                tbx_tennv.Text = null;
                tbx_MaNV.Text = null;
                tbx_MaNV.Enabled = false;
                rtb_diachi.Text = null;
                tbx_email.Enabled = false;
                tbx_tennv.Enabled = false;
                rtb_diachi.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btn_luu.Enabled = false;
                loadata();

            }


        }

        private void dtgview_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            if (Rowindex == BUS_QLNV.loadnv().Count || Rowindex == -1) return;
            tbx_email.Text = dtgview_nhanvien.Rows[Rowindex].Cells[0].Value.ToString();
            _emailvWhenclick = dtgview_nhanvien.Rows[Rowindex].Cells[0].Value.ToString();
            tbx_tennv.Text = dtgview_nhanvien.Rows[Rowindex].Cells[1].Value.ToString();
            rtb_diachi.Text = dtgview_nhanvien.Rows[Rowindex].Cells[2].Value.ToString();
            rbx_quantri.Checked = dtgview_nhanvien.Rows[Rowindex].Cells[3].Value.ToString() == "Quản trị" ? true : false;
            rbx_nv.Checked = dtgview_nhanvien.Rows[Rowindex].Cells[3].Value.ToString() == "Nhân viên" ? true : false;
            rbx_hd.Checked = dtgview_nhanvien.Rows[Rowindex].Cells[4].Value.ToString() == "Hoạt động" ? true : false;
            rbx_khd.Checked = dtgview_nhanvien.Rows[Rowindex].Cells[4].Value.ToString() == "Ngừng hoạt động" ? true : false;
            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            tbx_email.Enabled = true;
            tbx_tennv.Enabled = true;
            rtb_diachi.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            tbx_email.Enabled = false;


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn Sửa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var nhanvien = BUS_QLNV.loadnv().FirstOrDefault(c => c.Email == _emailvWhenclick);
                nhanvien.Tennv = tbx_tennv.Text;
                nhanvien.Manv = tbx_MaNV.Text;
                nhanvien.Diachi = rtb_diachi.Text;
                nhanvien.Vaitro = rbx_quantri.Checked;
                nhanvien.Tinhtrang = rbx_hd.Checked;
                nhanvien.Matkhau = BUS_QLNV.loadnv().Where(c => c.Email == tbx_email.Text).Select(c => c.Matkhau).FirstOrDefault();
                MessageBox.Show(BUS_QLNV.update(nhanvien), "Thông báo");
                tbx_email.Text = null;
                tbx_tennv.Text = null;
                tbx_MaNV.Text = null;
                tbx_MaNV.Enabled = false;
                rtb_diachi.Text = null;
                tbx_email.Enabled = false;
                tbx_tennv.Enabled = false;
                rtb_diachi.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btn_luu.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                loadata();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(BUS_QLNV.delete(_emailvWhenclick));
                tbx_email.Text = null;
                tbx_tennv.Text = null;
                rtb_diachi.Text = null;
                tbx_email.Enabled = false;
                tbx_tennv.Enabled = false;
                rtb_diachi.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btn_luu.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                loadata();
            }
        }

        private void tbx_tk_Click(object sender, EventArgs e)
        {
            tbx_tk.Text = null;
            tbx_tk.BackColor = Color.White;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            loadata(tbx_tk.Text);
            tbx_tk.Text = "Nhập tên nhân viên";
            tbx_tk.BackColor = Color.LightGray;
            resetvalue();

        }

        private void btn_ds_Click(object sender, EventArgs e)
        {
            loadata();
            resetvalue();
        }
        private void resetvalue()
        {
            tbx_tk.Text = "Nhập tên nhân viên";
            tbx_email.Text = null;
            tbx_tennv.Text = null;
            rtb_diachi.Text = null;
            tbx_email.Enabled = false;
            tbx_tennv.Enabled = false;
            rtb_diachi.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;


        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            loadata();
            resetvalue();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đóng không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
    }
}
