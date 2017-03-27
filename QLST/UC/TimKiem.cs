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
    public partial class TimKiem : UserControl
    {
        public TimKiem()
        {
            InitializeComponent();
            
        }
        private void xuat()
        {
            dgv_timkiem.DataSource = BUS.BUS.xuat_HH();
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            xuat();
        }
    }
}
