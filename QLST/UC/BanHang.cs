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
    public partial class BanHang : UserControl
    {
        public BanHang()
        {
            InitializeComponent();
        }
        bool themhd;
        bool themct;
        private void xuat()
        {
            dgv_hoadon.DataSource = BUS.BUS.xuat_hoadon();
            string ma = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            DataTable dt,dt1,dt2 = new DataTable();
            dt = BUS.BUS.xuat_HH();
            dt1 = BUS.BUS.xuat_NV();
            dt2 = BUS.BUS.xuat_KH();
            cmb_hh.DataSource = dt;
            cmb_tennv.DataSource = dt1;
            cmb_kh.DataSource = dt2;
            cmb_tennv.DisplayMember = "Tên NV";
            cmb_tennv.ValueMember = "Mã NV";
            cmb_hh.ValueMember = "Mã Hàng Hóa";
            cmb_hh.DisplayMember = "Tên Hàng Hóa";
            cmb_kh.ValueMember = "Mã Khách hàng";
            cmb_kh.DisplayMember = "Tên Khách hàng";
            cmb_hh.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_hh.AutoCompleteSource = AutoCompleteSource.ListItems;
            txt_mahd.Enabled = false;
            txt_macthd.Enabled = false;
            themhd = false;
            themct = false;
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
            cmb_kh.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
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

        private void txt_tien_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void dgv_ct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_macthd.Text = dgv_ct.CurrentRow.Cells[0].Value.ToString();
            cmb_hh.Text = dgv_ct.CurrentRow.Cells[1].Value.ToString();
            cmb_gia.Text = dgv_ct.CurrentRow.Cells[2].Value.ToString();
            txt_sl.Text = dgv_ct.CurrentRow.Cells[3].Value.ToString();
            cmb_dvt.Text= dgv_ct.CurrentRow.Cells[4].Value.ToString();
            txt_tien.Text = dgv_ct.CurrentRow.Cells[5].Value.ToString();
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

       
         private void reset1()
        {  
            txt_mahd.ResetText();
            cmb_tennv.ResetText();
            cmb_kh.ResetText();
            dtp_ngaylap.ResetText();
            txt_vat.ResetText();
           //  txt_tongtien.Text = "0";
            //if (txt_tongtien.Text == null) txt_tongtien.Text = 0.ToString();
        }
        private void reset2()
        {
            txt_macthd.ResetText();
            cmb_hh.ResetText();
            txt_sl.ResetText();
            cmb_dvt.ResetText();
            cmb_gia.ResetText();
            txt_tien.ResetText();
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_mahd.Enabled = true;
            reset1();
            txt_vat.Text = 0.1.ToString();
            themhd = true;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset1();
            reset2();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon a = new Hoadon();
            a.Mahd = txt_mahd.Text.Trim();
            a.Manv = cmb_tennv.SelectedValue.ToString();
            a.Makh = cmb_kh.SelectedValue.ToString();
            a.Ngaylap = dtp_ngaylap.Value;
            a.Vat = float.Parse(txt_vat.Text);
            a.Tongtien = float.Parse(txt_tongtien.Text);
            if (a.Mahd == null || a.Mahd == "") throw new Exception();
            if (BUS.BUS.sua_hoadon(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_mahd.Enabled = false;
            }
            xuat();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon a = new Hoadon();
            a.Mahd = txt_mahd.Text.Trim();
            if (BUS.BUS.xoa_hoadon(a) != 1)
                MessageBox.Show("Không xóa được");
            else
            {
               
                MessageBox.Show("Xóa Thành Công");
            }
            reset1();
            reset2();
            xuat();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (themhd)
            {

                Hoadon a = new Hoadon();
                a.Mahd = txt_mahd.Text.Trim();
                a.Manv = cmb_tennv.SelectedValue.ToString();
                a.Makh = cmb_kh.SelectedValue.ToString();
                a.Ngaylap = dtp_ngaylap.Value;
                a.Vat = float.Parse(txt_vat.Text);
                a.Tongtien = float.Parse(txt_tongtien.Text);
               // txt_tongtien.Text = "0";
                if (a.Mahd == null || a.Mahd == "") throw new Exception();
                if (BUS.BUS.them_hoadon(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_mahd.Enabled = false;
                }
                xuat();
            }
            else if (themct)
            {
                ChitietHoaDon b = new ChitietHoaDon();
                b.Macthd = txt_macthd.Text.Trim();
                b.Mahd = txt_mahd.Text.Trim();
                b.Mahh = cmb_hh.SelectedValue.ToString();
                b.Dongia = float.Parse(cmb_gia.Text);
                b.Soluong = int.Parse(txt_sl.Text);
                b.Tien = float.Parse(txt_tien.Text);
                if (BUS.BUS.them_cthd(b) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_macthd.Enabled = false;
                }
                string ma = txt_mahd.Text;
                dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
                txt_macthd.Enabled = false;
                tongtien();
            }else
            {
                if (txt_tongtien.Text != "0" && txt_tongtien.Text != null)
                {
                    if (MessageBox.Show("Bạn có muốn lưu tổng tiền ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        luutien();
                        MessageBox.Show("đã lưu tổng tiền");
                    }
                }
            }
        }

        private void txt_vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_hh_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Theem
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_macthd.Enabled = true;
            reset2();
            themct = true;
        }
        //Sửa
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ChitietHoaDon b = new ChitietHoaDon();
            b.Macthd = txt_macthd.Text.Trim();
            b.Mahd = txt_mahd.Text.Trim();
            b.Mahh = cmb_hh.SelectedValue.ToString();
            b.Dongia = float.Parse(cmb_gia.Text);
            b.Soluong = int.Parse(txt_sl.Text);
            b.Tien = float.Parse(txt_tien.Text);

            if (b.Macthd == null || b.Macthd == "") throw new Exception();
            if (BUS.BUS.sua_cthd(b) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_macthd.Enabled = false;
            }
           // else { MessageBox.Show("lỗi"); }
            string ma = txt_mahd.Text;
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            txt_macthd.Enabled = false;
            tongtien();
        }
        //Xóa
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChitietHoaDon a = new ChitietHoaDon();
            a.Macthd = txt_macthd.Text.Trim();
            if (BUS.BUS.xoa_cthd(a) != 1)
                MessageBox.Show("Không xóa được");
            else
            {

                MessageBox.Show("Xóa Thành Công");
            }
            reset1();
            reset2();
            string ma = txt_mahd.Text;
            dgv_ct.DataSource = BUS.BUS.xuat_cthd(ma);
            txt_macthd.Enabled = false;
            tongtien();
        }
        private void luutien()
        {
            Hoadon a = new Hoadon();
            a.Mahd = txt_mahd.Text.Trim();
            // float b = float.Parse(txt_tongtien.Text);
            //a.Tongtien = b;
            string b = txt_tongtien.Text;
            a.Tongtien = float.Parse(b);
            if (BUS.BUS.sua_hoadon1(a) == 1)
            {
               
                xuat();
            }
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if(txt_tongtien.Text != "0" && txt_tongtien.Text !=null)
            {
               luutien();
            }
        }
    }
}
