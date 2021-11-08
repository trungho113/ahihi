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


namespace _3_GUI_PresentationLayer
{
    public partial class Frm_thongke : Form
    {
        private IQLTHONGKE _QLTHONGKE;
        public Frm_thongke()
        {
            InitializeComponent();
            _QLTHONGKE = new QLTHONGKE();
            LoadDatanhapkho();
            LoadDatonkho();
        }

        void LoadDatonkho()
        {
            dtgview_tonkho.ColumnCount = 2;
            dtgview_tonkho.Columns[0].Name = "Tên Sản phẩm";
            dtgview_tonkho.Columns[1].Name = "Số lượng tồn";

            dtgview_tonkho.Rows.Clear();
            foreach (var x in _QLTHONGKE.viewSPTonKhos())
            {
                dtgview_tonkho.Rows.Add(x.TenSp, x.SoLuongTon);
            }

        }
        void LoadDatanhapkho()
        {
            dtgview_nhapkho.ColumnCount = 3;
            dtgview_nhapkho.Columns[0].Name = "Mã NV";
            dtgview_nhapkho.Columns[1].Name = "Tên NV";
            dtgview_nhapkho.Columns[2].Name = "Số lượng nhập";

            dtgview_nhapkho.Rows.Clear();
            foreach (var x in _QLTHONGKE.viewNhapKhos())
            {
                dtgview_nhapkho.Rows.Add(x.MaNV, x.TenNv, x.SoLuongNhap);
            }

        }
    }
}
