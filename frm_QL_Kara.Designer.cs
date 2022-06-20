
namespace QL_Quan_Kara
{
    partial class frm_QL_Kara
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.button_Laphoadon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_PanelNV = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Controls.Add(this.button_Laphoadon);
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 504);
            this.panel1.TabIndex = 0;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.DimGray;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Admin.Location = new System.Drawing.Point(-4, 68);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(200, 66);
            this.btn_Admin.TabIndex = 5;
            this.btn_Admin.Text = "ADMIN";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // button_Laphoadon
            // 
            this.button_Laphoadon.BackColor = System.Drawing.Color.DarkGray;
            this.button_Laphoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Laphoadon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.button_Laphoadon.ForeColor = System.Drawing.Color.White;
            this.button_Laphoadon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Laphoadon.Location = new System.Drawing.Point(-4, 2);
            this.button_Laphoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Laphoadon.Name = "button_Laphoadon";
            this.button_Laphoadon.Size = new System.Drawing.Size(200, 66);
            this.button_Laphoadon.TabIndex = 4;
            this.button_Laphoadon.Text = "LẬP HÓA ĐƠN ";
            this.button_Laphoadon.UseVisualStyleBackColor = false;
            this.button_Laphoadon.Click += new System.EventHandler(this.button_Laphoadon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 129);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QL_Quan_Kara.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // main_PanelNV
            // 
            this.main_PanelNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_PanelNV.Location = new System.Drawing.Point(202, 0);
            this.main_PanelNV.Name = "main_PanelNV";
            this.main_PanelNV.Size = new System.Drawing.Size(945, 639);
            this.main_PanelNV.TabIndex = 0;
            // 
            // frm_QL_Kara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 639);
            this.Controls.Add(this.main_PanelNV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QL_Kara";
            this.Text = "frm_QL_Kara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_QL_Kara_FormClosed);
            this.Load += new System.EventHandler(this.frm_QL_Kara_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel main_PanelNV;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button button_Laphoadon;
    }
}