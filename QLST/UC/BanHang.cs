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
namespace QLST.UC
{
    public partial class BanHang : UserControl
    {
        public BanHang()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgv_hoadon.DataSource = BUS.BUS.xuat_hoadon();
            string ma = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            DataTable dt,dt1 = new DataTable();
            dt = BUS.BUS.xuat_HH();
            dt1 = BUS.BUS.xuat_NV();
            cmb_hh.DataSource = dt;
            cmb_tennv.DataSource = dt1;
            cmb_tennv.DisplayMember = "Tên NV";
            cmb_tennv.ValueMember = "Mã NV";
            cmb_hh.ValueMember = "Mã Hàng Hóa";
            cmb_hh.DisplayMember = "Tên Hàng Hóa";
            cmb_hh.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_hh.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        
        private void BanHang_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            txt_mahd.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            cmb_tennv.Text = dgv_hoadon.CurrentRow.Cells[1].Value.ToString();
            txt_makh.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaylap.Text = dgv_hoadon.CurrentRow.Cells[3].Value.ToString();
            txt_vat.Text = dgv_hoadon.CurrentRow.Cells[4].Value.ToString();
            txt_tongtien.Text = dgv_hoadon.CurrentRow.Cells[5].Value.ToString();
        }

        private void cmb_hh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_hh.SelectedValue == null)
                return;
             string ma = cmb_hh.SelectedValue.ToString();
           
            DataTable dt1 = new DataTable();
            dt1 = BUS.BUS.xuat_HH1(ma);
            cmb_dvt.DataSource = dt1;
            cmb_gia.DataSource = dt1;
            cmb_dvt.DisplayMember = "Đơn vị tính";
            cmb_gia.DisplayMember = "Giá Bán";
        }
        void tinhtien()
        {
            int soluong = 0;
            int dongia = 0;
            int thanhtien = 0;
            try
            {
                int.TryParse(txt_sl.Text, out soluong);
                int.TryParse(cmb_gia.Text, out dongia);
                thanhtien = dongia * soluong;
                txt_tien.Text = thanhtien.ToString();


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

        private void txt_tien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_ct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_macthd.Text = dgv_ct.CurrentRow.Cells[0].Value.ToString();
            cmb_hh.Text = dgv_ct.CurrentRow.Cells[1].Value.ToString();
            cmb_gia.Text = dgv_ct.CurrentRow.Cells[2].Value.ToString();
            txt_sl.Text = dgv_ct.CurrentRow.Cells[3].Value.ToString();
            txt_tien.Text = dgv_ct.CurrentRow.Cells[4].Value.ToString();
        }

        private void cmb_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhtien();
        }
        void tongtien()
        {
            int sum = 0;
            for(int i = 0; i < dgv_ct.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgv_ct["Tiền", i].Value);
            }
            txt_tongtien.Text = sum.ToString();
        }
    }
}
