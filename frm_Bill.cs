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
    public partial class frm_Bill : Form
    {
        public String RoomId;
        public frm_Bill()
        {
            InitializeComponent();
            Load_cbb_Menu();
            Load_cbb_NhanVien();
            LoadRoom();
        }
        void LoadRoom()
        {
            var context = new Context();

            var talbleList = from p in context.ROOMs
                             select p;

            foreach (var item in talbleList)
            {
                Button btn = new Button();
                btn.Width = 90;
                btn.Height = 90;
                btn.Text = item.ROOM_NAME + Environment.NewLine + item.STATUS;
                btn.Tag = item.ID_ROOM;

                btn.Click += Btn_Click;

                if (item.STATUS == "Trống")
                    btn.BackColor = Color.LightGreen;
                else
                    btn.BackColor = Color.IndianRed;

                pn_table.Controls.Add(btn);
            }
        }

        void LoadGioHang(string maPhong)
        {
            var context = new Context();
            var tenKhach = from p in context.ROOM_ORDER
                           join t in context.CUSTOMERs
                           on p.ID_CUSTOMER equals t.ID_CUSTOMER
                           where p.ID_ROOM == maPhong && p.TIME_OUT == null
                           select t.CUSTOMER_NAME;

            txt_TenKhach.Text = tenKhach.First();
            txt_TenKhach.Enabled = false;
            btn_DatPhong.Enabled = false;
            var gioHang = from p in context.ORDER_S
                          join t in context.MENUs
                          on p.ID_MENU equals t.ID
                          join x in context.ROOM_ORDER
                          on p.ID_ROOM_ORDER equals x.ID_ROOM_ORDER
                          where x.ID_ROOM == lb_MaPhong.Text && x.TIME_OUT == null
                          select new
                          {
                              name = t.NAME,
                              amount = p.QTY,
                              price = p.TOTAL_PRICE,
                          };
            dataGridView1.DataSource = gioHang.ToList();
        }
        public void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            String maPhong = btn.Tag.ToString();
            var context = new Context();

            lb_MaPhong.Text = maPhong;
            var status_Phong = from p in context.ROOMs
                               where p.ID_ROOM == maPhong
                               select p.STATUS;
            if (status_Phong.First() == "Trống")
            {
                txt_TenKhach.Clear();
                txt_TenKhach.Enabled = true;
                btn_DatPhong.Enabled = true;
                dataGridView1.DataSource = null;
            }
            else
            {
                LoadGioHang(maPhong);

            }
        }
        public void Load_cbb_NhanVien()
        {
            var context = new Context();
            var nv = from p in context.EMPLOYEEs
                     select p;
            cbb_NV.DataSource = nv.ToList();
            cbb_NV.DisplayMember = "NAME";
            cbb_NV.ValueMember = "ID_EMPLOYEE";
        }
        public void Load_cbb_Menu()
        {
            var context = new Context();
            var menu = from p in context.MENUs
                       select p;
            cbb_menu.DataSource = menu.ToList();
            cbb_menu.DisplayMember = "NAME";
            cbb_menu.ValueMember = "ID";
        }
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            String tenKhach = txt_TenKhach.Text;
            if (tenKhach == "")
                MessageBox.Show("Hãy nhập tên khách hàng");
            else
            {
                THONGTINKHACHHANG frm = new THONGTINKHACHHANG(tenKhach, lb_MaPhong.Text);
                frm.ShowDialog();
                txt_TenKhach.Enabled = false;
                btn_DatPhong.Enabled = false;
                pn_table.Controls.Clear();
                LoadRoom();
            }

        }
        private void pn_table_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            if (txt_TenKhach.Enabled == true)
            {
                MessageBox.Show("Hãy nhập thông tin khách hàng!");

            }
            else
            {
                var context = new Context();
                int idMenu = Convert.ToInt32(cbb_menu.SelectedValue.ToString());
                var id_room_order = from p in context.ROOM_ORDER
                                    join t in context.ROOMs
                                    on p.ID_ROOM equals t.ID_ROOM
                                    where p.ID_ROOM == lb_MaPhong.Text && p.TIME_OUT == null
                                    select p.ID_ROOM_ORDER;
                var pr = from p in context.MENUs
                         where p.ID == idMenu
                         select p.PRICE;

                ORDER_S order = new ORDER_S();
                order.ID_MENU = idMenu;
                order.ID_ROOM_ORDER = Convert.ToInt32(id_room_order.First());
                order.QTY = Convert.ToInt32(num_menu.Value);
                order.TOTAL_PRICE = Convert.ToInt32(pr.First().ToString());


                context.ORDER_S.Add(order);
                context.SaveChanges();

                LoadGioHang(lb_MaPhong.Text);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(btn_DatPhong.Enabled == true)
            {
                MessageBox.Show("Phòng chưa có người đặt");
            }
            else
            if (cbb_NV.Text == "")
            {
                MessageBox.Show("Hãy chọn nhân viên thanh toán");
            }
            else
            {
                var context = new Context();
                var id_room_order = from p in context.ROOM_ORDER
                                    join t in context.ROOMs
                                    on p.ID_ROOM equals t.ID_ROOM
                                    where p.ID_ROOM == lb_MaPhong.Text && p.TIME_OUT == null
                                    select p.ID_ROOM_ORDER;
                object dataSource = dataGridView1.DataSource;
                object tb = dataSource;
                int giamgia;
                if (txt_GiamGia.Text == "")
                    giamgia = 0;
                else
                    giamgia = Convert.ToInt32(txt_GiamGia.Text);
                int id_r_c = id_room_order.First();
                int id_em = Convert.ToInt32(cbb_NV.SelectedValue.ToString());
                Bills frm = new Bills(tb, giamgia, id_r_c, id_em);
                frm.ShowDialog();
                pn_table.Controls.Clear();

                LoadRoom();
                dataGridView1.DataSource = null;
                txt_TenKhach.Text = "";
                lb_MaPhong.Text = "";
                txt_TenKhach.Enabled = true;
                btn_DatPhong.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Bill_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
