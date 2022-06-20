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
    public partial class Bills : Form
    {
        private object TB = new object();

        private long GiamGia = 0;
        private int Id_Room_Order;
        private int Id_Employee;
        public Bills(object tb, long giamgia, int id_room_order, int id_employee)
        {
            InitializeComponent();
            this.TB = tb;
            this.GiamGia = giamgia;
            this.Id_Room_Order = id_room_order;
            this.Id_Employee = id_employee;
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            lb_GiamGia.Text = GiamGia.ToString();
            dataGridView1.DataSource = TB;
            DateTime time_out = DateTime.Now;

            Context context = new Context();
            long tongtien = 0;
            int sl = 0;
            int price_menu = 0;
            int tonggio = 0;
            var time_in = from p in context.ROOM_ORDER
                          where p.ID_ROOM_ORDER == Id_Room_Order
                          select p.TIME_IN;

            var giaPhong = from p in context.ROOMs
                           join t in context.ROOM_ORDER
                           on p.ID_ROOM equals t.ID_ROOM
                           where t.ID_ROOM_ORDER == Id_Room_Order
                           select p.PRICE;
            var idPhong = from p in context.ROOM_ORDER
                          where p.ID_ROOM_ORDER == Id_Room_Order
                          select p.ID_ROOM;
            long giaphong = giaPhong.First();
             /* for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sl = Convert.ToInt32(dataGridView1.Rows[i].Cells[1]);
                price_menu = Convert.ToInt32(dataGridView1.Rows[i].Cells[2]);
                tongtien += sl * price_menu;
            }*/

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sl = Convert.ToInt32(row.Cells[1].Value);
                price_menu = Convert.ToInt32(row.Cells[2].Value);
                tongtien += sl * price_menu;
            }
            string temp = idPhong.First().ToString();
            ROOM rOOM = context.ROOMs.Single(p => p.ID_ROOM == temp);
            rOOM.STATUS = "Trống";

            ROOM_ORDER rOOM_ORDER = context.ROOM_ORDER.Single(p => p.ID_ROOM_ORDER == Id_Room_Order);
            rOOM_ORDER.TIME_OUT = time_out;
            //TimeSpan time =(time_out - time_in.First()).Duration() ;
            tonggio = (int)Math.Ceiling(time_out.Subtract(time_in.First()).TotalHours);
            tongtien += tonggio * giaphong - GiamGia;

            BILL bill = new BILL();
            bill.ID_ROOM_ORDER = Id_Room_Order;
            bill.ID_EMPLOYEE = Id_Employee;
            bill.TOTAL = tongtien;
            context.BILLs.Add(bill);
            context.SaveChanges();
            
            lb_MaHoaDon.Text = temp;
            lb_TenNhanVien.Text = lb_MaHoaDon.Text = (from p in context.BILLs
                                                      where p.ID_ROOM_ORDER == Id_Room_Order
                                                      select p.ID_BILL).First().ToString();

            lb_NgayLapHoaDon.Text = time_out.Date.ToString();
            lb_TenKhach.Text = (from p in context.ROOM_ORDER
                               join t in context.CUSTOMERs
                               on p.ID_CUSTOMER equals t.ID_CUSTOMER
                               where p.ID_ROOM_ORDER == Id_Room_Order
                               select t.CUSTOMER_NAME).First().ToString(); ;
            lb_Phong.Text = (from p in context.ROOMs
                            join t in context.ROOM_ORDER
                            on p.ID_ROOM equals t.ID_ROOM
                            where t.ID_ROOM_ORDER == Id_Room_Order
                            select p.ROOM_NAME).First().ToString();
            lb_SoGio.Text = tonggio.ToString();
            lb_GiamGia.Text = GiamGia.ToString();
            lb_TongTien.Text = tongtien.ToString();



        }
    }
}
