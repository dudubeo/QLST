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
using System.Data.Sql;
namespace QLST.UC
{
    public partial class Kho : UserControl
    {
       

        public Kho()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            DataTable dt1, dt2 = new DataTable();
            dgv_kho.DataSource = BUS.BUS.xuat_Kho();
            dt1 = BUS.BUS.xuat_NV();
           
            cmb_tenthukho.DataSource = dt1;
            cmb_tenthukho.DisplayMember = "Tên NV";
            cmb_tenthukho.ValueMember = "Mã NV";



        }

        private void Kho_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_kho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makho.Text = dgv_kho.CurrentRow.Cells[0].Value.ToString();
            txt_tenkho.Text = dgv_kho.CurrentRow.Cells[1].Value.ToString();
            cmb_tenthukho.Text = dgv_kho.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = dgv_kho.CurrentRow.Cells[3].Value.ToString();
           

        }
    }
}
