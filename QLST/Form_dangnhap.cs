using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLST
{
    public partial class Form_dangnhap : Form
    {
        public Form_dangnhap()
        {
            InitializeComponent();
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_tk_Click(object sender, EventArgs e)
        {
            txt_tk.Text = "";
        }

        private void txt_mk_Click(object sender, EventArgs e)
        {
            txt_mk.Text = "";
        }

        private void lbl_dangnhap_Click(object sender, EventArgs e)
        {
            if ((txt_tk.Text == "") || (txt_mk.Text == ""))
            {
                errortk.Icon = Properties.Resources._1481007008_Error;
                errortk.SetError(txt_tk, "Tài Khoản Lỗi");
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                errortk.Icon = Properties.Resources._1481007037_Tick_Mark;
                errortk.SetError(txt_tk, "OK");
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ONTHQMQ;Initial Catalog=quanlisieuthi2;Integrated Security=True");
                con.Open();
                string s = "select count(*) from taikhoan where username='" + txt_tk.Text + "'and password='" + txt_mk.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form_Main a = new Form_Main();
                    a.Show();
                    con.Close();
                }
                else
                {
                    // MessageBox.Show("loi");
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
            }
        }

        private void checkBox_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_mk.UseSystemPasswordChar)
            {
                txt_mk.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mk.UseSystemPasswordChar = true;
            }
        }

        private void txt_tk_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_tk.Text))
            {
                errortk.Icon = Properties.Resources._1481007008_Error;
                errortk.SetError(txt_tk, "Tài Khoản Lỗi");

            }
            else
            {
                errortk.Icon = Properties.Resources._1481007037_Tick_Mark;
                errortk.SetError(txt_tk, "OK");

            }
        }

        private void txt_tk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txt_mk.Focus();
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) lbl_dangnhap_Click(sender, null);
        }
    }
}
