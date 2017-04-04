using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QLST
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            QLST.UC.TimKiem a = new UC.TimKiem();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Tìm Kiếm";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            QLST.UC.ThongKe a = new UC.ThongKe();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Thống Kê";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void kho_Click(object sender, EventArgs e)
        {
            QLST.UC.Kho a = new UC.Kho();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Quản lí Kho";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void Nhanvien_Click(object sender, EventArgs e)
        {
            QLST.UC.NhanVien a = new UC.NhanVien();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Quản lí Nhân Viên";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void khachhang_Click(object sender, EventArgs e)
        {
            QLST.UC.KhachHang a = new UC.KhachHang();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Quản lí Khách Hàng";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void hanghoa_Click(object sender, EventArgs e)
        {
            QLST.UC.HangHoa a = new UC.HangHoa();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Quản lí Hàng Hóa";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void nhaphang_Click(object sender, EventArgs e)
        {
            QLST.UC.NhapHang a = new UC.NhapHang();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Nhập Hàng";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void banhang_Click(object sender, EventArgs e)
        {
            QLST.UC.BanHang a = new UC.BanHang();
            a.Dock = DockStyle.Fill;
            panel_main.Controls.Add(a);
            lbl.Text = "Bán Hàng";
            foreach (Control ctrl in panel_main.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 42)
            {
                panel1.Width = 268;
                timkiem.Visible = true;
                khachhang.Visible = true;
                hanghoa.Visible = true;
                Nhanvien.Visible = true;
                kho.Visible = true;
                thongke.Visible = true;
                Help.Visible = true;
            }
            else
            {
                panel1.Width = 42;
                
                timkiem.Visible = false;
                khachhang.Visible = false;
                hanghoa.Visible = false;
                Nhanvien.Visible = false;
                kho.Visible = false;
                thongke.Visible = false;
                Help.Visible = false;
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            panel_main.Width = 1052;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Process.Start("http://qlsieuthi.comeze.com/");
        }
    }
}
