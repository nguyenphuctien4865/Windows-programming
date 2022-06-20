
namespace QL_Quan_Kara
{
    partial class frm_Bill
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThemMon = new System.Windows.Forms.Button();
            this.num_menu = new System.Windows.Forms.NumericUpDown();
            this.cbb_menu = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.cbb_NV = new System.Windows.Forms.ComboBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.txt_TenKhach = new System.Windows.Forms.TextBox();
            this.pn_table = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_menu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ThemMon);
            this.panel2.Controls.Add(this.num_menu);
            this.panel2.Controls.Add(this.cbb_menu);
            this.panel2.Location = new System.Drawing.Point(595, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 61);
            this.panel2.TabIndex = 0;
            // 
            // btn_ThemMon
            // 
            this.btn_ThemMon.Location = new System.Drawing.Point(234, 5);
            this.btn_ThemMon.Name = "btn_ThemMon";
            this.btn_ThemMon.Size = new System.Drawing.Size(102, 53);
            this.btn_ThemMon.TabIndex = 2;
            this.btn_ThemMon.Text = "thêm món";
            this.btn_ThemMon.UseVisualStyleBackColor = true;
            this.btn_ThemMon.Click += new System.EventHandler(this.btn_ThemMon_Click);
            // 
            // num_menu
            // 
            this.num_menu.Location = new System.Drawing.Point(185, 21);
            this.num_menu.Name = "num_menu";
            this.num_menu.Size = new System.Drawing.Size(40, 22);
            this.num_menu.TabIndex = 1;
            // 
            // cbb_menu
            // 
            this.cbb_menu.FormattingEnabled = true;
            this.cbb_menu.Location = new System.Drawing.Point(3, 21);
            this.cbb_menu.Name = "cbb_menu";
            this.cbb_menu.Size = new System.Drawing.Size(176, 24);
            this.cbb_menu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(595, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 372);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(336, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txt_GiamGia);
            this.panel4.Controls.Add(this.cbb_NV);
            this.panel4.Controls.Add(this.btn_ThanhToan);
            this.panel4.Location = new System.Drawing.Point(595, 521);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 109);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "giảm giá";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Location = new System.Drawing.Point(88, 57);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(122, 22);
            this.txt_GiamGia.TabIndex = 3;
            // 
            // cbb_NV
            // 
            this.cbb_NV.FormattingEnabled = true;
            this.cbb_NV.Location = new System.Drawing.Point(88, 8);
            this.cbb_NV.Name = "cbb_NV";
            this.cbb_NV.Size = new System.Drawing.Size(122, 24);
            this.cbb_NV.TabIndex = 0;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(234, 11);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(102, 52);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btn_DatPhong);
            this.panel5.Controls.Add(this.txt_TenKhach);
            this.panel5.Location = new System.Drawing.Point(595, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 51);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Location = new System.Drawing.Point(234, 10);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(102, 36);
            this.btn_DatPhong.TabIndex = 2;
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // txt_TenKhach
            // 
            this.txt_TenKhach.Location = new System.Drawing.Point(88, 17);
            this.txt_TenKhach.Name = "txt_TenKhach";
            this.txt_TenKhach.Size = new System.Drawing.Size(137, 22);
            this.txt_TenKhach.TabIndex = 3;
            // 
            // pn_table
            // 
            this.pn_table.AutoScroll = true;
            this.pn_table.Location = new System.Drawing.Point(3, 3);
            this.pn_table.Name = "pn_table";
            this.pn_table.Size = new System.Drawing.Size(589, 627);
            this.pn_table.TabIndex = 2;
            this.pn_table.Click += new System.EventHandler(this.pn_table_Click);
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Location = new System.Drawing.Point(598, 124);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(68, 16);
            this.lb_MaPhong.TabIndex = 1;
            this.lb_MaPhong.Text = "Mã Phòng";
            // 
            // frm_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 632);
            this.Controls.Add(this.lb_MaPhong);
            this.Controls.Add(this.pn_table);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frm_Bill";
            this.Text = "frm_Bill";
            this.Load += new System.EventHandler(this.frm_Bill_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_menu)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ThemMon;
        private System.Windows.Forms.NumericUpDown num_menu;
        private System.Windows.Forms.ComboBox cbb_menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DatPhong;
        private System.Windows.Forms.TextBox txt_TenKhach;
        private System.Windows.Forms.FlowLayoutPanel pn_table;
        private System.Windows.Forms.Label lb_MaPhong;
        private System.Windows.Forms.ComboBox cbb_NV;
        private System.Windows.Forms.Label label3;
    }
}