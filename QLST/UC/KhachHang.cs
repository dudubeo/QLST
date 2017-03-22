using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLST.BUS;
namespace QLST.UC
{
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_kh.DataSource = BUS.BUS.xuat_KH();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgv_kh.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dgv_kh.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = dgv_kh.CurrentRow.Cells[2].Value.ToString();
            cmb_gt.Text = dgv_kh.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_kh.CurrentRow.Cells[4].Value.ToString();
            txt_diem.Text = dgv_kh.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
