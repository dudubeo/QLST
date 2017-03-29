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
using QLST.DAL;
using QLST.DT0;
using QLST.Properties;
namespace QLST.UC
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_nv.DataSource = BUS.BUS.xuat_NV();            
            
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dgv_nv.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = dgv_nv.CurrentRow.Cells[1].Value.ToString();
            txt_chucvu.Text = dgv_nv.CurrentRow.Cells[2].Value.ToString();
            cmb_gt.Text = dgv_nv.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = dgv_nv.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dgv_nv.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
