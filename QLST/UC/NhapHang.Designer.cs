namespace QLST.UC
{
    partial class NhapHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_phieunhap = new System.Windows.Forms.DataGridView();
            this.dgv_ctnhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 49);
            this.panel3.TabIndex = 5;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(267, 15);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(193, 22);
            this.txt_tongtien.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng Tiền";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(94, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_ctnhap);
            this.panel2.Controls.Add(this.dgv_phieunhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 277);
            this.panel2.TabIndex = 7;
            // 
            // dgv_phieunhap
            // 
            this.dgv_phieunhap.AllowUserToAddRows = false;
            this.dgv_phieunhap.AllowUserToDeleteRows = false;
            this.dgv_phieunhap.AllowUserToResizeRows = false;
            this.dgv_phieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phieunhap.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_phieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieunhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_phieunhap.Location = new System.Drawing.Point(0, 0);
            this.dgv_phieunhap.Name = "dgv_phieunhap";
            this.dgv_phieunhap.RowTemplate.Height = 24;
            this.dgv_phieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieunhap.Size = new System.Drawing.Size(660, 277);
            this.dgv_phieunhap.TabIndex = 3;
            // 
            // dgv_ctnhap
            // 
            this.dgv_ctnhap.AllowUserToAddRows = false;
            this.dgv_ctnhap.AllowUserToDeleteRows = false;
            this.dgv_ctnhap.AllowUserToResizeRows = false;
            this.dgv_ctnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ctnhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ctnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ctnhap.Location = new System.Drawing.Point(660, 0);
            this.dgv_ctnhap.Name = "dgv_ctnhap";
            this.dgv_ctnhap.RowTemplate.Height = 24;
            this.dgv_ctnhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ctnhap.Size = new System.Drawing.Size(274, 277);
            this.dgv_ctnhap.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(515, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 184);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Hàng Hóa";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "NhapHang";
            this.Size = new System.Drawing.Size(934, 531);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_phieunhap;
        private System.Windows.Forms.DataGridView dgv_ctnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
