using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Quan_Kara
{
    public partial class frm_QL_Kara : Form
    {
        private string ROLE;
        public frm_QL_Kara(String role)
        {
            InitializeComponent();
            this.ROLE = role;
            
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        { 
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_PanelNV.Controls.Add(childForm);
            main_PanelNV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button_Laphoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Bill());
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Admin());
        }

        private void frm_QL_Kara_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_QL_Kara_Load(object sender, EventArgs e)
        {
            if (ROLE == "employee")
            {
                btn_Admin.Enabled = false;
            }
        }
    }
}
