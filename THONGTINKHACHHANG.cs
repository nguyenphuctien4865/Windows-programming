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
    public partial class THONGTINKHACHHANG : Form
    {
        private string tenKhach = "";
        private string maPhong = "";
        public THONGTINKHACHHANG()
        {
            InitializeComponent();
        }
        public THONGTINKHACHHANG(string tenkhach, string maphong)
        {
            InitializeComponent();
            this.tenKhach = tenkhach;
            this.maPhong = maphong;
        }

        private void THONGTINKHACHHANG_Load(object sender, EventArgs e)
        {
            lb_TenKhach.Text = tenKhach;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            var context = new Context();
            CUSTOMER cus = new CUSTOMER();
            cus.CUSTOMER_NAME = lb_TenKhach.Text;
            cus.EMAIL = txt_Email.Text;
            cus.ID_CARD = txt_CMND.Text;
            cus.PHONE = txt_SDT.Text;
            context.CUSTOMERs.Add(cus);
            //context.SaveChanges();

            ROOM_ORDER rOOM_ORDER = new ROOM_ORDER();
            rOOM_ORDER.ID_CUSTOMER = cus.ID_CUSTOMER;
            rOOM_ORDER.ID_ROOM = maPhong;
            rOOM_ORDER.TIME_IN = DateTime.Now;
            rOOM_ORDER.CUSTOMER = cus;
            context.ROOM_ORDER.Add(rOOM_ORDER);

            ROOM room = context.ROOMs.Single(p=> p.ID_ROOM == maPhong);
            room.STATUS = "Có Khách";
            context.SaveChanges();

            this.Close();
        }
    }
}
