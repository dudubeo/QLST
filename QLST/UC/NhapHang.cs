using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST.UC
{
    public partial class NhapHang : UserControl
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_pn.DataSource = BUS.BUS.xuat_pn();
            string ma = dgv_pn.CurrentRow.Cells[0].Value.ToString();
            dgv_ctnhap.DataSource = BUS.BUS.xuat_ctn(ma);
            DataTable dt, dt1 = new DataTable();
            dt = BUS.BUS.xuat_NV();
            dt1 = BUS.BUS.xuat_Kho();
            cmb_tenthukho.DataSource = dt;
            cmb_tenkho.DataSource = dt1;
            cmb_tenkho.DisplayMember = "Tên Kho";
            cmb_tenkho.ValueMember = "Mã Kho";
            cmb_tenthukho.ValueMember = "Mã NV";
            cmb_tenthukho.DisplayMember = "Tên NV";
            cmb_tenthukho.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_tenthukho.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_pn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mapn.Text = dgv_pn.CurrentRow.Cells[0].Value.ToString();
            cmb_tenkho.Text = dgv_pn.CurrentRow.Cells[1].Value.ToString();
            cmb_tenthukho.Text = dgv_pn.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaylap.Text = dgv_pn.CurrentRow.Cells[3].Value.ToString();
            txt_vat.Text = dgv_pn.CurrentRow.Cells[4].Value.ToString();
            txt_tongtien.Text = dgv_pn.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgv_ctnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            txt_mactn.Text = dgv_ctnhap.CurrentRow.Cells[0].Value.ToString();
            cmb_tenhh.Text = dgv_ctnhap.CurrentRow.Cells[1].Value.ToString();
            txt_sl.Text = dgv_ctnhap.CurrentRow.Cells[2].Value.ToString();
            //cmb_gia.Text = dgv_ctnhap.CurrentRow.Cells[3].Value.ToString();
            txt_tien.Text = dgv_ctnhap.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
