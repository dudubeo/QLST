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
using QLST.DT0;
using QLST.DAL;
using QLST.Properties;
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
            txt_makh.Enabled = false;
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
        private void reset()
        {
            txt_makh.ResetText();
            txt_tenkh.ResetText();
            txt_diem.ResetText();
            cmb_gt.ResetText();
            txt_diachi.ResetText();
            txt_sdt.ResetText();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = true;
            reset();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Makh = txt_makh.Text.Trim();
            a.Tenkh = txt_tenkh.Text.Trim();
            a.Sdt = txt_sdt.Text.Trim();
            a.Gioitinh = cmb_gt.Text.Trim();
            a.Diachi = txt_diachi.Text.Trim();
            a.Diem = int.Parse(txt_diem.Text);
            if (a.Makh == null) throw new Exception();
            if (BUS.BUS.sua_kh(a) == 1)
            {
                MessageBox.Show("Sửa thành công");
                txt_makh.Enabled = false;
            }
            xuat();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Makh = txt_makh.Text.Trim();
            a.Tenkh = txt_tenkh.Text.Trim();
            a.Sdt = txt_sdt.Text.Trim();
            a.Gioitinh = cmb_gt.Text.Trim();
            a.Diachi = txt_diachi.Text.Trim();
            a.Diem = int.Parse(txt_diem.Text);
            if (a.Makh == null) throw new Exception();
            if (MessageBox.Show("Bạn có muốn Thêm Khách hàng ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS.BUS.them_kh(a) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_makh.Enabled = false;
                }
            }

            xuat();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Makh = txt_makh.Text.Trim();
            if (BUS.BUS.xoa_kh(a) != 1)
                MessageBox.Show("Không xóa được");
            else
            {

                MessageBox.Show("Xóa Thành Công");
            }
            reset();
            xuat();
        }
    }
}
