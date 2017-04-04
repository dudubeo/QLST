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
namespace QLST.UC
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgv_thongke.DataSource = BUS.BUS.tk_hh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgv_thongke.DataSource = BUS.BUS.tk_nhap();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dgv_thongke.DataSource = BUS.BUS.tk_ban();
        }
    }
}
