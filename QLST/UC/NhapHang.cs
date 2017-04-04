using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLST.DT0;
namespace QLST.UC
{
  
    public partial class NhapHang : UserControl
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        bool pn = false;
        bool ctn = false;
        private void khoainput()
        {
            cmb_gia.Enabled = false;
            txt_tien.Enabled = false;
            txt_tongtien.Enabled = false;
        }
       private void reset2()
        {
            txt_mactn.Clear();
            cmb_tenhh.ResetText();
            cmb_gia.ResetText();
            txt_sl.Clear();
            txt_tien.Clear();
        }
        private void reset1()
        {
            txt_mapn.Clear();
            txt_tongtien.Clear();
            txt_vat.Clear();
            cmb_tenkho.ResetText();
            cmb_tenthukho.ResetText();
        }
        private void xuat()
        {
            dgv_pn.DataSource = BUS.BUS.xuat_pn();
        
            DataTable dt, dt1,dt2 = new DataTable();
            dt = BUS.BUS.xuat_NV();
            dt1 = BUS.BUS.xuat_Kho();
            cmb_tenthukho.DataSource = dt;
            cmb_tenkho.DataSource = dt1;
            cmb_tenkho.DisplayMember = "Tên Kho";
            cmb_tenkho.ValueMember = "Mã Kho";
            cmb_tenthukho.ValueMember = "Mã NV";
            cmb_tenthukho.DisplayMember = "Tên NV";
            dt2 = BUS.BUS.xuat_HH();
            cmb_tenhh.DataSource = dt2;
            cmb_tenhh.DisplayMember = "Tên Hàng Hóa";
            cmb_tenhh.ValueMember = "Mã Hàng Hóa";
            cmb_tenthukho.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_tenthukho.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            xuat();
            khoainput();

        }

        private void dgv_pn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mapn.Text = dgv_pn.CurrentRow.Cells[0].Value.ToString();
            cmb_tenkho.Text = dgv_pn.CurrentRow.Cells[1].Value.ToString();
            cmb_tenthukho.Text = dgv_pn.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaylap.Text = dgv_pn.CurrentRow.Cells[3].Value.ToString();
            txt_vat.Text = dgv_pn.CurrentRow.Cells[4].Value.ToString();
            txt_tongtien.Text = dgv_pn.CurrentRow.Cells[5].Value.ToString();
            txt_mapn.Enabled = false;
            dgv_ctnhap.DataSource = BUS.BUS.xuat_ctn(txt_mapn.Text);
        }

        private void dgv_ctnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            txt_mactn.Text = dgv_ctnhap.CurrentRow.Cells[0].Value.ToString();
            cmb_tenhh.Text = dgv_ctnhap.CurrentRow.Cells[1].Value.ToString();
            txt_sl.Text = dgv_ctnhap.CurrentRow.Cells[2].Value.ToString();
            //cmb_gia.Text = dgv_ctnhap.CurrentRow.Cells[3].Value.ToString();
            txt_tien.Text = dgv_ctnhap.CurrentRow.Cells[4].Value.ToString();
            txt_mactn.Enabled = false;
        }

        private void cmb_tenhh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tenhh.SelectedValue == null)
                return;
            string ma = cmb_tenhh.SelectedValue.ToString();

            DataTable dt1 = new DataTable();
            dt1 = BUS.BUS.xuat_HH1(ma);
        
            cmb_gia.DataSource = dt1;
         
            cmb_gia.DisplayMember = "Giá Bán";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reset2();
            ctn = true;
            txt_mactn.Enabled = true;
        }
        void tinhtien()
        {
            int soluong = 0;
            float dongia = 0;
            float thanhtien = 0;
            try
            {
                int.TryParse(txt_sl.Text, out soluong);
                float.TryParse(cmb_gia.Text, out dongia);
                thanhtien = dongia * soluong;
                int y = (int)thanhtien;
                txt_tien.Text = y.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
           
        }

        private void txt_sl_TextChanged(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ctn==true)
            {

                Chitietnhap a = new Chitietnhap();
              
                a.Mactn = txt_mactn.Text;
                a.Mapn = txt_mapn.Text;
                a.Soluong = int.Parse(txt_sl.Text);
                a.Dongia = float.Parse(cmb_gia.Text);
                a.Tien = float.Parse(txt_tien.Text);
                a.Mahh = cmb_tenhh.SelectedValue.ToString();
                if (BUS.BUS.them_ctn(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                dgv_ctnhap.DataSource = BUS.BUS.xuat_ctn(txt_mapn.Text);
                dgv_pn.DataSource = BUS.BUS.xuat_pn();
                ctn = false;
                reset2();
            }
            else if (pn == true)
            {
                PhieuNhap a = new PhieuNhap();
                a.Mapn = txt_mapn.Text;
                a.Makho = cmb_tenkho.SelectedValue.ToString();
                a.Mathukho = cmb_tenthukho.SelectedValue.ToString();
                a.Vat = float.Parse(txt_vat.Text);
                a.Ngaylap = dtp_ngaylap.Value;
                if (BUS.BUS.them_pn(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                dgv_pn.DataSource=BUS.BUS.xuat_pn();
                
                pn = false;
                reset1();
                reset2();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Chitietnhap a = new Chitietnhap();

            a.Mactn = txt_mactn.Text;
            a.Mapn = txt_mapn.Text;
            a.Soluong = int.Parse(txt_sl.Text);
            a.Dongia = float.Parse(cmb_gia.Text);
            a.Tien = float.Parse(txt_tien.Text);
            a.Mahh = cmb_tenhh.SelectedValue.ToString();
            if (BUS.BUS.sua_ctn(a) == 1)
            {
                MessageBox.Show("Sửa Thành Công");
            }
            dgv_ctnhap.DataSource = BUS.BUS.xuat_ctn(txt_mapn.Text);
            dgv_pn.DataSource = BUS.BUS.xuat_pn();
            reset2();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Chitietnhap a = new Chitietnhap();

            a.Mactn = txt_mactn.Text;
          
            if (BUS.BUS.xoa_ctn(a) == 1)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            dgv_ctnhap.DataSource = BUS.BUS.xuat_ctn(txt_mapn.Text);
            dgv_pn.DataSource = BUS.BUS.xuat_pn();
            reset2();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset1();
            txt_mapn.Enabled = true;
            pn = true;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap a = new PhieuNhap();
            a.Mapn = txt_mapn.Text;
            a.Makho = cmb_tenkho.SelectedValue.ToString();
            a.Mathukho = cmb_tenthukho.SelectedValue.ToString();
            a.Vat = float.Parse(txt_vat.Text);
            a.Ngaylap = dtp_ngaylap.Value;
            if (BUS.BUS.sua_pn(a) == 1)
            {
                MessageBox.Show("Sửa Thành Công");
            }
            dgv_pn.DataSource = BUS.BUS.xuat_pn();
            reset1();
            reset2();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap a = new PhieuNhap();
            a.Mapn = txt_mapn.Text;
            if (BUS.BUS.xoa_pn(a) == 1)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            dgv_pn.DataSource = BUS.BUS.xuat_pn();
            reset1();
            reset2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset1();
            reset2();
        }
    }
}
