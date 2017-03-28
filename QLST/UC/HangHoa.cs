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
    public partial class HangHoa : UserControl
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_hh.DataSource = BUS.BUS.xuat_HH();
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahh.Text = dgv_hh.CurrentRow.Cells[0].Value.ToString();
            txt_tenhh.Text = dgv_hh.CurrentRow.Cells[1].Value.ToString();
            txt_chungloai.Text = dgv_hh.CurrentRow.Cells[2].Value.ToString();
            txt_dvt.Text  = dgv_hh.CurrentRow.Cells[3].Value.ToString();
            txt_trongluong.Text= dgv_hh.CurrentRow.Cells[4].Value.ToString();
            txt_giaban.Text = dgv_hh.CurrentRow.Cells[5].Value.ToString();
            txt_noisx.Text = dgv_hh.CurrentRow.Cells[6].Value.ToString();
            txt_hsd.Text = dgv_hh.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
