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

    public partial class Frm_KhachHang : Form
    {
        public static string manv;
       private IQLKHService _QLKHService;
       private KhachHangViewModel _KhachHangViewModel;
        private Validateform _validateform;
        public Frm_KhachHang()
        {
            InitializeComponent();
            _QLKHService = new QLKHService();
            loaddata();
            _KhachHangViewModel = new KhachHangViewModel();
            _validateform = new Validateform();
        }
        void loaddata()
        {
            dtgritview.ColumnCount = 4;
            dtgritview.Columns[0].HeaderText = "Điện thoại";
            dtgritview.Columns[1].HeaderText = "Họ và tên";
            dtgritview.Columns[2].HeaderText = "Địa chỉ";
            dtgritview.Columns[3].HeaderText = "Giới tính";
            dtgritview.Rows.Clear();
            if (_QLKHService.GetlstViewKhachHangModel() == null) return;
            foreach (var x in _QLKHService.GetlstViewKhachHangModel())
            {
                dtgritview.Rows.Add(x.khachhang.Dienthoai, x.khachhang.Tenkhach, x.khachhang.Diachi, x.khachhang.Phai);
            }

        } 
        void loaddata(string sdt)
        {
            dtgritview.ColumnCount = 4;
            dtgritview.Columns[0].HeaderText = "Điện thoại";
            dtgritview.Columns[1].HeaderText = "Họ và tên";
            dtgritview.Columns[2].HeaderText = "Địa chỉ";
            dtgritview.Columns[3].HeaderText = "Giới tính";
            dtgritview.Rows.Clear();
            if (_QLKHService.GetlstViewKhachHangModel() == null) return;
            foreach (var x in _QLKHService.timkiem(sdt))
            {
                dtgritview.Rows.Add(x.Dienthoai, x.Tenkhach, x.Diachi, x.Phai);
            }

        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            resetvalue();
        }

        private void resetvalue()
        {
            tbx_tk.Text = "Nhập số điện thoại khách hàng";
            tbx_dienthoai.Text = null;
            tbx_hoten.Text = null;
            rtb_diachi.Text = null;
            rbn_nam.Checked = false;
            rbn_nu.Checked = false;
            rbn_nam.Enabled = false;
            rbn_nu.Enabled = false;
            tbx_dienthoai.Enabled = false;
            tbx_hoten.Enabled = false;
            rtb_diachi.Enabled = false;   
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_ds.Enabled = true;
        }


        private bool checkloi()
        {
            if (_validateform.checkNull(tbx_dienthoai.Text)|| _validateform.checkNull(tbx_hoten.Text) || _validateform.checkNull(rtb_diachi.Text) )
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo");
                return true;
            }
            if (_validateform.checkSDT(tbx_dienthoai.Text))
            {
                MessageBox.Show("yêu cầu bạn nhập đúng số điện thoại", "Thông báo");
                return true;
            }
            if (_validateform.checkChu(tbx_hoten.Text))
            {
                MessageBox.Show("Tên phải nhập bằng chữ", "Thông báo");
                return true;
            }
            if (rbn_nam.Checked==false&& rbn_nu.Checked==false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo");
                return true;
            }
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            tbx_dienthoai.Text = null;
            tbx_hoten.Text = null;
            rtb_diachi.Text = null;
            rbn_nam.Checked = false;
            rbn_nu.Checked = false;           
            tbx_dienthoai.Enabled = true;
            tbx_hoten.Enabled = true;
            rtb_diachi.Enabled = true;
            rbn_nam.Enabled = true;
            rbn_nu.Enabled = true;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            loaddata();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn Thêm không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Khachhang khachhang = new Khachhang();
                khachhang.Dienthoai = tbx_dienthoai.Text;
                khachhang.Tenkhach = tbx_hoten.Text;
                khachhang.Diachi = rtb_diachi.Text;
                khachhang.Phai = rbn_nam.Checked ? "Nam" : "Nữ";
                khachhang.Manv = manv;
                MessageBox.Show(_QLKHService.add(khachhang), "Thông báo");
                tbx_dienthoai.Text = null;
                tbx_hoten.Text = null;
                rtb_diachi.Text = null;
                rbn_nam.Checked = false;
                rbn_nu.Checked = false;
                tbx_dienthoai.Enabled = false;
                tbx_hoten.Enabled = false;
                rtb_diachi.Enabled = false;
                rbn_nam.Enabled = false;
                rbn_nu.Enabled = false;
                btn_luu.Enabled = false; 
            }
        }

        private void dtgritview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            if (Rowindex == _QLKHService.GetlstViewKhachHangModel().Count || Rowindex == -1) return;
            tbx_dienthoai.Text = dtgritview.Rows[Rowindex].Cells[0].Value.ToString();
            tbx_hoten.Text = dtgritview.Rows[Rowindex].Cells[1].Value.ToString();
            rtb_diachi.Text = dtgritview.Rows[Rowindex].Cells[2].Value.ToString();
            rbn_nam.Checked = dtgritview.Rows[Rowindex].Cells[3].Value.ToString() == "Nam" ? true : false;
            rbn_nu.Checked = dtgritview.Rows[Rowindex].Cells[3].Value.ToString() == "Nữ" ? true : false;       
            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            tbx_dienthoai.Enabled = true;
            tbx_hoten.Enabled = true;
            rtb_diachi.Enabled = true;
            rbn_nam.Enabled = true;
            rbn_nu.Enabled = true;
            tbx_dienthoai.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn sửa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var khachHang = _QLKHService.getlstKhachHang().FirstOrDefault(c => c.Dienthoai == tbx_dienthoai.Text);
                khachHang.Tenkhach = tbx_hoten.Text;
                khachHang.Diachi = rtb_diachi.Text;
                khachHang.Phai = rbn_nam.Checked ? "Nam" : "Nữ";
                khachHang.Manv = manv;
                MessageBox.Show(_QLKHService.update(khachHang), "Thông báo");
                tbx_dienthoai.Text = null;
                tbx_hoten.Text = null;
                rtb_diachi.Text = null;
                tbx_dienthoai.Enabled = false;
                tbx_hoten.Enabled = false;
                rtb_diachi.Enabled = false;
                rbn_nam.Enabled = false;
                rbn_nu.Enabled = false;
                btn_luu.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                loaddata(); 
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_QLKHService.delete(tbx_dienthoai.Text));
                tbx_dienthoai.Text = null;
                tbx_hoten.Text = null;
                rtb_diachi.Text = null;
                tbx_dienthoai.Enabled = false;
                tbx_hoten.Enabled = false;
                rtb_diachi.Enabled = false;
                rbn_nam.Enabled = false;
                rbn_nu.Enabled = false;
                btn_luu.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                loaddata(); 
            }
        }

        private void tbx_tk_Click(object sender, EventArgs e)
        {
            tbx_tk.Text = null;
            tbx_tk.BackColor = Color.White;
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            loaddata(tbx_tk.Text);
            tbx_tk.Text = "Nhập số điện thoại khách hàng";
            tbx_tk.BackColor = Color.LightGray;
            resetvalue();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            loaddata();
            resetvalue();
        }

        private void btn_ds_Click(object sender, EventArgs e)
        {
            loaddata();
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
