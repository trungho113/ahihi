using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Product : Form
    {
        private IQLSANPHAMService _QLSANPHAMService;
        public static string _manv;
        private string _saveDirectory;
        private string _checkUrlImage;
        private string _filename;
        private string _filesavePath;
        private string _fileAddress;
        private Validateform _validateform;

        public Frm_Product()
        {
            InitializeComponent();
            _QLSANPHAMService = new QLSANPHAMService();
            loadata();
            _validateform = new Validateform();
        }

        void loadata()
        {
            dtgview.ColumnCount = 7;

            dtgview.Columns[0].HeaderText = "Mã sản Phẩm";
            dtgview.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtgview.Columns[2].HeaderText = "Số Lượng";
            dtgview.Columns[3].HeaderText = "Đơn Giá Nhập";
            dtgview.Columns[4].HeaderText = "Đơn Giá Bán";
            dtgview.Columns[5].HeaderText = "Hình Ảnh";
            dtgview.Columns[6].HeaderText = "Ghi chú";

            dtgview.Rows.Clear();
            foreach (var x in _QLSANPHAMService.loadhang())
            {
                dtgview.Rows.Add(x.Mahang, x.Tenhang, x.Soluong, x.Dongiaban, x.Dongiaban, x.Hinhanhsp, x.Ghichu);
            }

        }
        void loadata(string ten)
        {
            dtgview.ColumnCount = 7;

            dtgview.Columns[0].HeaderText = "Mã sản Phẩm";
            dtgview.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtgview.Columns[2].HeaderText = "Số Lượng";
            dtgview.Columns[3].HeaderText = "Đơn Giá Nhập";
            dtgview.Columns[4].HeaderText = "Đơn Giá Bán";
            dtgview.Columns[5].HeaderText = "Hình Ảnh";
            dtgview.Columns[6].HeaderText = "Ghi chú";

            dtgview.Rows.Clear();
            foreach (var x in _QLSANPHAMService.loadhang().Where(c => c.Tenhang.StartsWith(ten)).ToList())
            {
                dtgview.Rows.Add(x.Mahang, x.Tenhang, x.Soluong, x.Dongiaban, x.Dongiaban, x.Hinhanhsp, x.Ghichu);
            }

        }



        private void dtgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
            int Rowindex = e.RowIndex;
            if (Rowindex == _QLSANPHAMService.loadhang().Count || Rowindex == -1) return;
            tbx_Masp.Text = dtgview.Rows[Rowindex].Cells[0].Value.ToString();
            tbx_tenhang.Text = dtgview.Rows[Rowindex].Cells[1].Value.ToString();
            tbx_soluong.Text = dtgview.Rows[Rowindex].Cells[2].Value.ToString();
            tbx_dongianhap.Text = dtgview.Rows[Rowindex].Cells[3].Value.ToString();
            tbx_dongiaban.Text = dtgview.Rows[Rowindex].Cells[4].Value.ToString();
            tbx_hinh.Text = dtgview.Rows[Rowindex].Cells[5].Value.ToString();
            _checkUrlImage = tbx_hinh.Text;
            pbImg.Image = Image.FromFile(saveDirectory + dtgview.Rows[Rowindex].Cells[5].Value.ToString());
            tbx_ghichu.Text = dtgview.Rows[Rowindex].Cells[6].Value.ToString();
            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            tbx_tenhang.Enabled = true;
            tbx_soluong.Enabled = true;
            tbx_dongianhap.Enabled = true;
            tbx_dongiaban.Enabled = true;
            tbx_ghichu.Enabled = true;

        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            resetvalue();
        }

        private void resetvalue()
        {
            tbx_tk.Text = "Nhập Tên Sản Phẩm";
            tbx_Masp.Text = null;
            tbx_tenhang.Text = null;
            tbx_soluong.Text = null;
            tbx_dongianhap.Text = null;
            tbx_dongiaban.Text = null;
            tbx_hinh.Text = null;
            tbx_ghichu.Text = null;
            tbx_Masp.Enabled = false;
            tbx_tenhang.Enabled = false;
            tbx_soluong.Enabled = false;
            tbx_dongianhap.Enabled = false;
            tbx_dongiaban.Enabled = false;
            tbx_ghichu.Enabled = false;
            tbx_hinh.Enabled = false;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_ds.Enabled = true;
        }

        private bool checkloi()
        {
            if (_validateform.checkNull(tbx_Masp.Text) || _validateform.checkNull(tbx_tenhang.Text) || _validateform.checkNull(tbx_soluong.Text) || _validateform.checkNull(tbx_dongiaban.Text) || _validateform.checkNull(tbx_dongianhap.Text) || _validateform.checkNull(tbx_hinh.Text) || _validateform.checkNull(tbx_ghichu.Text))
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo");
                return true;
            }
            if (_validateform.checkSo(tbx_soluong.Text) || _validateform.checkSo(tbx_dongianhap.Text) || _validateform.checkSo(tbx_dongiaban.Text))
            {
                MessageBox.Show("Yêu cầu bạn nhập số lượng, đơn giá nhập, đơn giá bán là số", "Thông báo");
                return true;
            }
            return false;
        }

        private void btn_mohinh_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.Title = "Chọn hình ảnh minh họa";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _fileAddress = openFile.FileName;
                pbImg.Image = Image.FromFile(_fileAddress);
                _filename = Path.GetFileName(openFile.FileName);
                _saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
                _filesavePath = _saveDirectory + "\\Images\\" + _filename;//combine with file name
                tbx_hinh.Text = "\\Images\\" + _filename;
            }

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn thêm không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Hang hang = new Hang();
                hang.Mahang = tbx_Masp.Text;
                hang.Tenhang = tbx_tenhang.Text;
                hang.Soluong = Convert.ToInt32(tbx_soluong.Text);
                hang.Dongiaban = float.Parse(tbx_dongiaban.Text);
                hang.Dongianhap = float.Parse(tbx_dongianhap.Text);
                hang.Hinhanhsp = "\\Images\\" + _filename;
                hang.Ghichu = tbx_ghichu.Text;
                hang.Manv = _manv;
                MessageBox.Show(_QLSANPHAMService.add(hang), "Thông báo");
                File.Copy(_fileAddress, _filesavePath, true);
                resetvalue();
                loadata();
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            tbx_Masp.Text = null;
            tbx_tenhang.Text = null;
            tbx_soluong.Text = null;
            tbx_dongianhap.Text = null;
            tbx_dongiaban.Text = null;
            tbx_hinh.Text = null;
            tbx_ghichu.Text = null;
            tbx_Masp.Enabled = true;
            tbx_tenhang.Enabled = true;
            tbx_soluong.Enabled = true;
            tbx_dongianhap.Enabled = true;
            tbx_dongiaban.Enabled = true;
            tbx_ghichu.Enabled = true;
            btn_them.Enabled = true;
            btn_luu.Enabled = true;
            btn_dong.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_ds.Enabled = true;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (checkloi()) return;
            if (MessageBox.Show("Bạn có thật sự muốn Sửa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var hang = _QLSANPHAMService.loadhang().FirstOrDefault(c => c.Mahang == tbx_Masp.Text);
                hang.Tenhang = tbx_tenhang.Text;
                hang.Soluong = Convert.ToInt32(tbx_soluong.Text);
                hang.Dongianhap = float.Parse(tbx_dongianhap.Text);
                hang.Dongiaban = float.Parse(tbx_dongiaban.Text);
                hang.Hinhanhsp = tbx_hinh.Text;
                hang.Ghichu = tbx_ghichu.Text;
                hang.Manv = _manv;
                if (tbx_hinh.Text != _checkUrlImage)
                {
                    File.Copy(_fileAddress, _filesavePath, true);
                }
                MessageBox.Show(_QLSANPHAMService.update(hang), "Thông báo");
                resetvalue();
                loadata();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_QLSANPHAMService.delete(tbx_Masp.Text));
                resetvalue();
                loadata();
            }
        }
        private void btn_boqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            loadata();
        }

        private void btn_ds_Click(object sender, EventArgs e)
        {
            resetvalue();
            loadata();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đóng không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
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
            tbx_tk.Text = "Nhập số điện thoại khách hàng";
            tbx_tk.BackColor = Color.LightGray;
            resetvalue();
        }

    }
}
