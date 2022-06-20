using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace QL_Quan_Kara
{
    public partial class frm_Admin : Form
    {
        ROOM room = new ROOM();
        MENU menu = new MENU();
        ACCOUNT account = new ACCOUNT();
        EMPLOYEE emp = new EMPLOYEE();
        public frm_Admin()
        {
            InitializeComponent();
        }




        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Admin_Load_1(object sender, EventArgs e)
        {
            TabBill_Load();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                case 1:
                    TabRoom_Load();
                    break;
                case 2:
                    TabMenu_Load();
                    break;
                case 3:
                    TabAccount_Load();
                    break;
                case 4:
                    TabEmployee_Load();
                    break;
                case 5:
                    TabBill_Load();
                    break;
                default:
                    TabBill_Load();
                    break;
            }

        }
        #region Tab Room
        public void TabRoom_Load()
        {
            using (var context = new Context())

            {

                var rl = context.ROOMs
                    .Select(p => new
                    {
                        p.ID_ROOM,
                        p.ROOM_NAME,
                        p.ROOM_TYPE,
                        p.CAPACITY,
                        p.PRICE
                    });
                dgvRoom.DataSource = rl.ToList();
            }
            txtID_Room.Clear();
            txtName_Room.Clear();
            txtCapacity_Room.Clear();
            cbType_Room.ResetText();
            txtPrice_Room.Clear();
        }

        private void dgvRoom_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //To handle 'ConstraintException' default error dialog (for example, unique value)
                if ((e.Exception) is System.Data.ConstraintException)
                {
                    // ErrorText glyphs show
                    dgvBill.Rows[e.RowIndex].ErrorText = "must be unique value";
                    dgvBill.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "must be unique value";

                    //...or MessageBox show
                    MessageBox.Show(e.Exception.Message, "Error ConstraintException",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Suppress a ConstraintException
                    e.ThrowException = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: dataGridView1_DataError",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Room_Click(object sender, EventArgs e)
        {
            if (txtID_Room.Text != "")
            {
                var roomId = txtID_Room.Text;
                using (var context = new Context())
                {
                    var toDelete = context.ROOMs.Find(roomId);

                    context.ROOMs.Remove(toDelete);
                    context.SaveChanges();
                }
            }
            TabRoom_Load();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAdd_Room_Click(object sender, EventArgs e)
        {
            if (txtID_Room.Text != "")
            {

                room.ID_ROOM = txtID_Room.Text;
                room.ROOM_NAME = txtName_Room.Text;
                room.ROOM_TYPE = cbType_Room.Text.ToString();
                room.CAPACITY = Convert.ToInt32(txtCapacity_Room.Text);
                room.PRICE = Convert.ToInt32(txtPrice_Room.Text);

                using (var context = new Context())
                {
                    if (context.ROOMs.Find(room.ID_ROOM) == null)
                    {
                        context.ROOMs.Add(room);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại mã phòng này!");
                    }
                }
                TabRoom_Load();
            }
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_Room.Text = dgvRoom.CurrentRow.Cells[0].Value.ToString();
            txtName_Room.Text = dgvRoom.CurrentRow.Cells[1].Value.ToString();
            txtCapacity_Room.Text = dgvRoom.CurrentRow.Cells[3].Value.ToString();
            cbType_Room.Text = dgvRoom.CurrentRow.Cells[2].Value.ToString();
            txtPrice_Room.Text = dgvRoom.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Room_Click(object sender, EventArgs e)
        {
            var r = dgvRoom.CurrentCell.RowIndex;
            var rMaID = dgvRoom.Rows[r].Cells[0].Value.ToString();
            if (txtID_Room.Text != "")
            {

                using (var context = new Context())
                {
                    var curRoom = context.ROOMs.Find(rMaID);
                    if (curRoom != null)
                    {
                        curRoom.ID_ROOM = txtID_Room.Text;
                        curRoom.ROOM_NAME = txtName_Room.Text;
                        curRoom.ROOM_TYPE = cbType_Room.Text;
                        curRoom.PRICE = Convert.ToInt32(txtPrice_Room.Text);
                        curRoom.CAPACITY = Convert.ToInt32(txtCapacity_Room.Text);
                        context.SaveChanges();
                    }
                }

            }
            TabRoom_Load();
        }

        private void btnSearch_Room_Click(object sender, EventArgs e)
        {

            var strSearch = txtSearch_Room.Text.Trim();
            using (var context = new Context())
            {
                var querry = context.ROOMs
                    .Where(p => p.ID_ROOM.Contains(strSearch))
                    .Select(p => new
                    {
                        p.ID_ROOM,
                        p.ROOM_NAME,
                        p.ROOM_TYPE,
                        p.CAPACITY,
                        p.PRICE
                    });


                dgvRoom.DataSource = querry.ToList();
            }


        }
        #endregion

        #region Tab Menu
        public void TabMenu_Load()
        {
            using (var context = new Context())

            {

                var mnl = context.MENUs
                    .Select(p => new
                    {
                        p.ID,
                        p.NAME,
                        p.PRICE
                    });
                dgvMenu.DataSource = mnl.ToList();
            }
            txtName_Menu.Clear();
            txtPrice_Menu.Clear();
        }

        private void btnSearch_Menu_Click(object sender, EventArgs e)
        {
            var strSearch = txtSearch_Menu.Text.Trim();
            using (var context = new Context())
            {
                var querry = context.MENUs
                    .Where(p => p.NAME.Contains(strSearch))
                    .Select(p => new
                    {
                        p.ID,
                        p.NAME,
                        p.PRICE
                    });

                dgvMenu.DataSource = querry.ToList();
            }
        }

        private void btnAdd_Menu_Click(object sender, EventArgs e)
        {
            if (txtName_Menu.Text != "")
            {

                menu.NAME = txtName_Menu.Text;
                menu.PRICE = Convert.ToInt32(txtPrice_Menu.Text);

                using (var context = new Context())
                {
                    var querry = context.MENUs
                        .Any(p => p.NAME.Contains(menu.NAME));

                    if (!querry)
                    {
                        context.MENUs.Add(menu);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại mã món này!");
                    }
                }

            }
            TabMenu_Load();
        }

        private void btnDelete_Menu_Click(object sender, EventArgs e)
        {



            var menuID = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value.ToString());
            using (var context = new Context())
            {
                var toDelete = context.MENUs.Find(menuID);

                context.MENUs.Remove(toDelete);
                context.SaveChanges();
            }

            TabMenu_Load();
        }
        private void btnUpdate_Menu_Click(object sender, EventArgs e)
        {
            var mn = dgvMenu.CurrentCell.RowIndex;
            var mnID = Convert.ToInt32(dgvMenu.Rows[mn].Cells[0].Value.ToString());
            if (txtName_Menu.Text != "")
            {

                using (var context = new Context())
                {
                    var curMenu = context.MENUs.Find(mnID);
                    if (curMenu != null)
                    {
                        curMenu.NAME = txtName_Menu.Text;
                        curMenu.PRICE = Convert.ToInt32(txtPrice_Menu.Text);
                        context.SaveChanges();
                    }
                }
            }
            TabMenu_Load();

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName_Menu.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            txtPrice_Menu.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString();

        }

        #endregion

        #region Tab Account
        public void TabAccount_Load()
        {
            using (var context = new Context())

            {

                var acl = context.ACCOUNTs
                    .Select(p => new
                    {
                        p.ID_EMPLOYEE,
                        p.ACCOUNT_NAME,
                        p.PASSWORD,
                        p.ROLE,
                    });
                dgvAccount.DataSource = acl.ToList();
                cbNameEmp_Acc.DataSource = context.EMPLOYEEs.ToList();
                cbNameEmp_Acc.ValueMember = "ID_EMPLOYEE";
                cbNameEmp_Acc.DisplayMember = "NAME";
            }
            txtName_Account.Clear();
            txtPassword_Account.Clear();
            txtRole_Account.Clear();
            txtSearch_Account.Clear();


        }

        private void btnAdd_Account_Click(object sender, EventArgs e)
        {
            if (txtName_Account.Text != "")
            {

                account.ACCOUNT_NAME = txtName_Account.Text;
                account.PASSWORD = txtPassword_Account.Text;
                account.ROLE = txtRole_Account.Text;
                account.ID_EMPLOYEE = Convert.ToInt32(cbNameEmp_Acc.SelectedValue);
                using (var context = new Context())
                {
                    var querry1 = context.ACCOUNTs
                        .Any(p => p.ACCOUNT_NAME.Contains(account.ACCOUNT_NAME));
                    var querry2 = context.ACCOUNTs.Find(account.ID_EMPLOYEE);



                    if (querry1)
                    {
                        MessageBox.Show("Đã tồn tại tài khoản này!");

                    }
                    else if (querry2 != null)
                    {
                        MessageBox.Show("Người này đã có tài khoản");
                    }
                    else
                    {
                        context.ACCOUNTs.Add(account);
                        context.SaveChanges();
                    }
                }

            }
            TabAccount_Load();
        }

        private void btnDelete_Account_Click(object sender, EventArgs e)
        {

            if (txtName_Account.Text != "")
            {
                var acN = txtName_Account.Text;
                using (var context = new Context())
                {
                    var toDelete = context.ACCOUNTs
                        .Where(x => x.ACCOUNT_NAME == acN).First();
                    if (toDelete != null)
                    {

                        context.ACCOUNTs.Remove(toDelete);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản");
                    }
                }
            }
            else
            {
                var acID = cbNameEmp_Acc.SelectedValue;
                using (var context = new Context())
                {
                    var toDelete = context.ACCOUNTs.Find(acID);
                    if (toDelete != null)
                    {

                        context.ACCOUNTs.Remove(toDelete);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản");
                    }
                }

            }
            TabAccount_Load();
        }

        private void btnUpdate_Account_Click(object sender, EventArgs e)
        {
            var r = dgvAccount.CurrentCell.RowIndex;
            var acN = dgvAccount.Rows[r].Cells[0].Value;
            if (txtName_Account.Text != "")
            {

                using (var context = new Context())
                {
                    var curAC = context.ACCOUNTs.Find(acN);
                    if (curAC != null)
                    {
                        curAC.ACCOUNT_NAME = txtName_Account.Text;
                        curAC.PASSWORD = txtPassword_Account.Text;
                        curAC.ROLE = txtRole_Account.Text;
                        curAC.ID_EMPLOYEE = Convert.ToInt32(cbNameEmp_Acc.SelectedValue);
                        context.SaveChanges();
                    }
                }
            }
            TabAccount_Load();
        }

        private void btnSearch_Account_Click(object sender, EventArgs e)
        {
            var strSearch = txtSearch_Account.Text.Trim();
            using (var context = new Context())
            {
                var querry = context.ACCOUNTs
                    .Where(p => p.ACCOUNT_NAME.Contains(strSearch))
                    .Select(p => new
                    {
                        p.ID_EMPLOYEE,
                        p.ACCOUNT_NAME,
                        p.PASSWORD,
                        p.ROLE
                    });

                dgvAccount.DataSource = querry.ToList();
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.IsNullOrEmpty(dgvAccount.CurrentRow.Cells[1].Value as string))
            {
                txtName_Account.Text = "";
            }
            else
            {
                txtName_Account.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            }
            if (String.IsNullOrWhiteSpace(dgvAccount.CurrentRow.Cells[2].Value as string))
            {
                txtPassword_Account.Text = "";
            }
            else
            {

                txtPassword_Account.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            }
            if (String.IsNullOrEmpty(dgvAccount.CurrentRow.Cells[3].Value as string))
            {
                txtRole_Account.Text = "";
            }
            else
            {

                txtRole_Account.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            }
            cbNameEmp_Acc.SelectedValue = dgvAccount.CurrentRow.Cells[0].Value;
        }
        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        #region Tab Employee
        public void TabEmployee_Load()
        {
            using (var context = new Context())

            {

                var empl = context.EMPLOYEEs
                    .Select(p => new
                    {
                        p.ID_EMPLOYEE,
                        p.NAME,
                        p.PHONE,
                        p.EMAIL,
                        p.ID_CARD,
                        p.ADDRESS,
                        p.DoB,
                        p.ROLE_EMOLOYEE
                    });
                dgvEmployee.DataSource = empl.ToList();
            }
            txtAddress_Emp.Clear();
            txtCapacity_Room.Clear();
            txtIDCard_Emp.Clear();
            txtName_Emp.Clear();
            txtPhone_Emp.Clear();
            txtRole_Emp.Clear();
            txtSearch_Emp.Clear();
            txtEmail_Emp.Clear();

        }

        private void btnAdd_Emp_Click(object sender, EventArgs e)
        {

            if (txtName_Emp.Text != "")
            {
                emp = new EMPLOYEE
                {
                    NAME = txtName_Emp.Text,
                    PHONE = txtPhone_Emp.Text,
                    EMAIL = txtEmail_Emp.Text,
                    ADDRESS = txtAddress_Emp.Text,
                    ID_CARD = txtIDCard_Emp.Text.Trim(),
                    DoB = dtEmployee.Value.Date,
                    ROLE_EMOLOYEE = txtRole_Emp.Text
                };
            
                    using (var context = new Context())
                    {
                        var querry = context.EMPLOYEEs
                            .Where(p => p.ID_CARD.Contains(emp.ID_CARD));

                        if (querry.ToList().Count == 0)
                        {
                            context.EMPLOYEEs.Add(emp);
                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại nhân viên này này!");
                        }
                    }

                }
                TabEmployee_Load();
            
            
           
        }

        private void btnDelete_Emp_Click(object sender, EventArgs e)
        {
            var EmpID = dgvEmployee.CurrentRow.Cells[0].Value;
            
            using (var context = new Context())

            {              
                var toDelete = context.EMPLOYEEs.Find(EmpID);

                if (toDelete != null)
                {
                    /*toDelete.ACCOUNT.ID_EMPLOYEE = DBNull.Value;*/
                    context.EMPLOYEEs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản");
                }
            }
            TabEmployee_Load();
        }



        private void btnUpdate_Emp_Click(object sender, EventArgs e)
        {
            var r = dgvEmployee.CurrentCell.RowIndex;

            using (var context = new Context())
            {

                var Id = Convert.ToInt32(dgvEmployee.Rows[r].Cells[0].Value);
                var curEmp = context.EMPLOYEEs
                    .Find(Id);
                if (curEmp == null) throw new Exception("");

                context.EMPLOYEEs.Attach(curEmp);
                curEmp.NAME = txtName_Emp.Text;
                curEmp.ADDRESS = txtAddress_Emp.Text;
                curEmp.EMAIL = txtEmail_Emp.Text;
                curEmp.ID_CARD = txtIDCard_Emp.Text;
                curEmp.PHONE = txtPhone_Emp.Text;
                curEmp.ROLE_EMOLOYEE = txtRole_Emp.Text;
                curEmp.DoB = dtEmployee.Value.Date;
                curEmp.ACCOUNT = context.ACCOUNTs.Find(Id);
                context.ACCOUNTs.Attach(curEmp.ACCOUNT);
                context.SaveChanges();
            }
            TabEmployee_Load();

        }


        private void btnSearch_Emp_Click(object sender, EventArgs e)
        {
            var strSearch = txtSearch_Emp.Text;
            using (var context = new Context())
            {
                var querry = context.EMPLOYEEs
                    .Where(p => p.NAME.Contains(strSearch))
                    .Select(p => new
                    {
                        p.ID_EMPLOYEE,
                        p.NAME,
                        p.PHONE,
                        p.EMAIL,
                        p.ID_CARD,
                        p.ADDRESS,
                        p.DoB,
                        p.ROLE_EMOLOYEE
                    });

                dgvEmployee.DataSource = querry.ToList();
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName_Emp.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtPhone_Emp.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtEmail_Emp.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtIDCard_Emp.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtAddress_Emp.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            dtEmployee.Value = Convert.ToDateTime(dgvEmployee.CurrentRow.Cells[6].Value);
            txtRole_Emp.Text = dgvEmployee.CurrentRow.Cells[7].Value.ToString();

        }

        private void txtSearch_Emp_TextChanged(object sender, EventArgs e)
        {
            var strSearch = txtSearch_Emp.Text.Trim();
            using (var context = new Context())
            {
                var querry = context.EMPLOYEEs
                    .Where(p => p.NAME.Contains(strSearch))
                    .Select(p => new
                    {
                        p.ID_EMPLOYEE,
                        p.NAME,
                        p.PHONE,
                        p.EMAIL,
                        p.ID_CARD,
                        p.ADDRESS,
                        p.DoB,
                        p.ROLE_EMOLOYEE
                    });

                dgvAccount.DataSource = querry.ToList();
            }
        }


        #endregion

        #region Tab Bill
        private void btnBill_Click(object sender, EventArgs e)
        {
            DateTime frDate = dtFromDate_Bill.Value.Date;
            DateTime toDate = dtToDate_Bill.Value.Date;

            using (var context = new Context())
            {
                var querry = from b in context.BILLs
                             join r in context.ROOM_ORDER
                             on b.ID_ROOM_ORDER equals r.ID_ROOM_ORDER
                             where (DbFunctions.TruncateTime(r.TIME_IN) >= frDate
                             && DbFunctions.TruncateTime(r.TIME_OUT) <= toDate )
                             select new
                             {
                                 b.ID_BILL,
                                 b.ID_ROOM_ORDER,
                                 b.ID_EMPLOYEE,
                                 b.TAX,
                                 b.TOTAL,
                                 r.TIME_OUT 
                             };

                dgvBill.DataSource = querry.ToList();
            }
        }

        public void TabBill_Load()
        {
            using (var context = new Context())

            {
                var empl = from b in context.BILLs
                           join r in context.ROOM_ORDER
                           on b.ID_ROOM_ORDER equals r.ID_ROOM_ORDER
                           select new
                           {
                               b.ID_BILL,
                               b.ID_ROOM_ORDER,
                               b.ID_EMPLOYEE,
                               b.TAX,
                               b.TOTAL,
                               r.TIME_OUT
                           };
                dgvBill.DataSource = empl.ToList();
            }


        }
        #endregion
    }
}
