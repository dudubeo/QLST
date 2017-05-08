namespace QLST
{
    partial class Form_dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dangnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_dk = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_dangnhap = new System.Windows.Forms.Label();
            this.checkBox_hienmk = new System.Windows.Forms.CheckBox();
            this.lbl_quenmk = new System.Windows.Forms.Label();
            this.errortk = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lbl_x);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 60);
            this.panel1.TabIndex = 0;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.ForeColor = System.Drawing.Color.White;
            this.lbl_x.Location = new System.Drawing.Point(305, 8);
            this.lbl_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(19, 22);
            this.lbl_x.TabIndex = 2;
            this.lbl_x.Text = "x";
            this.lbl_x.Click += new System.EventHandler(this.lbl_x_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 49);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Want new account?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Controls.Add(this.lbl_dk);
            this.panel4.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel4.Location = new System.Drawing.Point(243, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 34);
            this.panel4.TabIndex = 0;
            // 
            // lbl_dk
            // 
            this.lbl_dk.AutoSize = true;
            this.lbl_dk.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dk.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_dk.Location = new System.Drawing.Point(15, 7);
            this.lbl_dk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dk.Name = "lbl_dk";
            this.lbl_dk.Size = new System.Drawing.Size(61, 19);
            this.lbl_dk.TabIndex = 0;
            this.lbl_dk.Text = "Sign In";
            this.lbl_dk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(21, 98);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(293, 41);
            this.txt_tk.TabIndex = 2;
            this.txt_tk.Text = "User name";
            this.txt_tk.Click += new System.EventHandler(this.txt_tk_Click);
            this.txt_tk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tk_KeyDown);
            this.txt_tk.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(21, 160);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mk.Multiline = true;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(293, 41);
            this.txt_mk.TabIndex = 3;
            this.txt_mk.Text = "Password";
            this.txt_mk.Click += new System.EventHandler(this.txt_mk_Click);
            this.txt_mk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mk_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lbl_dangnhap);
            this.panel3.Location = new System.Drawing.Point(22, 235);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 46);
            this.panel3.TabIndex = 4;
            // 
            // lbl_dangnhap
            // 
            this.lbl_dangnhap.AutoSize = true;
            this.lbl_dangnhap.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangnhap.ForeColor = System.Drawing.Color.White;
            this.lbl_dangnhap.Location = new System.Drawing.Point(98, 3);
            this.lbl_dangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dangnhap.Name = "lbl_dangnhap";
            this.lbl_dangnhap.Size = new System.Drawing.Size(106, 38);
            this.lbl_dangnhap.TabIndex = 1;
            this.lbl_dangnhap.Text = "Log In";
            this.lbl_dangnhap.Click += new System.EventHandler(this.lbl_dangnhap_Click);
            // 
            // checkBox_hienmk
            // 
            this.checkBox_hienmk.AutoSize = true;
            this.checkBox_hienmk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_hienmk.ForeColor = System.Drawing.Color.White;
            this.checkBox_hienmk.Location = new System.Drawing.Point(21, 208);
            this.checkBox_hienmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_hienmk.Name = "checkBox_hienmk";
            this.checkBox_hienmk.Size = new System.Drawing.Size(145, 21);
            this.checkBox_hienmk.TabIndex = 5;
            this.checkBox_hienmk.Text = "Show password";
            this.checkBox_hienmk.UseVisualStyleBackColor = true;
            this.checkBox_hienmk.CheckedChanged += new System.EventHandler(this.checkBox_hienmk_CheckedChanged);
            // 
            // lbl_quenmk
            // 
            this.lbl_quenmk.AutoSize = true;
            this.lbl_quenmk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quenmk.ForeColor = System.Drawing.Color.White;
            this.lbl_quenmk.Location = new System.Drawing.Point(179, 208);
            this.lbl_quenmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quenmk.Name = "lbl_quenmk";
            this.lbl_quenmk.Size = new System.Drawing.Size(153, 17);
            this.lbl_quenmk.TabIndex = 6;
            this.lbl_quenmk.Text = "Forgot a password?";
            // 
            // errortk
            // 
            this.errortk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errortk.ContainerControl = this;
            this.errortk.Icon = ((System.Drawing.Icon)(resources.GetObject("errortk.Icon")));
            this.errortk.RightToLeft = true;
            // 
            // Form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(337, 354);
            this.Controls.Add(this.lbl_quenmk);
            this.Controls.Add(this.checkBox_hienmk);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dangnhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_dangnhap;
        private System.Windows.Forms.CheckBox checkBox_hienmk;
        private System.Windows.Forms.Label lbl_quenmk;
        private System.Windows.Forms.ErrorProvider errortk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_dk;
    }
}