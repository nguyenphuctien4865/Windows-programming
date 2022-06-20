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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập tên đăng nhập!!!");
            }
            else
            {
                Context context = new Context();
                var pass = from p in context.ACCOUNTs
                           where p.ACCOUNT_NAME == txt_TenDangNhap.Text
                           select p.PASSWORD;
                var role = from p in context.ACCOUNTs
                               where p.ACCOUNT_NAME == txt_TenDangNhap.Text
                               select p.ROLE;
                if (pass.Count() <= 0)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!");
                }
                else
                {
                    if (txt_MatKhau.Text == pass.First())
                    {
                        frm_QL_Kara frm = new frm_QL_Kara(role.First());
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!");
                    }
                }
            }
        }
    }
}
