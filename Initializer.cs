using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace QL_Quan_Kara
{
    public class Initializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            try
            {
                #region Initialize Room
                var room = new ROOM()
                {
                    ID_ROOM = "PH01",
                    ROOM_NAME = "Phòng 1",
                    ROOM_TYPE = "Nhỏ",
                    PRICE = 100000,
                    CAPACITY = 4,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH02",
                    ROOM_NAME = "Phòng 2",
                    ROOM_TYPE = "Nhỏ",
                    PRICE = 100000,
                    CAPACITY = 4,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH03",
                    ROOM_NAME = "Phòng 3",
                    ROOM_TYPE = "Nhỏ",
                    PRICE = 100000,
                    CAPACITY = 4,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH04",
                    ROOM_NAME = "Phòng 4",
                    ROOM_TYPE = "Nhỏ",
                    PRICE = 100000,
                    CAPACITY = 4,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH05",
                    ROOM_NAME = "Phòng 5",
                    ROOM_TYPE = "Nhỏ",
                    PRICE = 100000,
                    CAPACITY = 4,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH06",
                    ROOM_NAME = "Phòng 6",
                    ROOM_TYPE = "Trung bình",
                    PRICE = 150000,
                    CAPACITY = 6,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH07",
                    ROOM_NAME = "Phòng 7",
                    ROOM_TYPE = "Trung bình",
                    PRICE = 150000,
                    CAPACITY = 6,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH08",
                    ROOM_NAME = "Phòng 8",
                    ROOM_TYPE = "Trung bình",
                    PRICE = 150000,
                    CAPACITY = 6,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH09",
                    ROOM_NAME = "Phòng 9",
                    ROOM_TYPE = "Trung bình",
                    PRICE = 150000,
                    CAPACITY = 6,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PH010",
                    ROOM_NAME = "Phòng 10",
                    ROOM_TYPE = "Trung bình",
                    PRICE = 150000,
                    CAPACITY = 6,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

             

                room = new ROOM()
                {
                    ID_ROOM = "PHV01",
                    ROOM_NAME = "Phòng vip 1",
                    ROOM_TYPE = "Lớn",
                    PRICE = 300000,
                    CAPACITY = 8,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PHV02",
                    ROOM_NAME = "Phòng vip 2",
                    ROOM_TYPE = "Lớn",
                    PRICE = 300000,
                    CAPACITY = 8,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PHV03",
                    ROOM_NAME = "Phòng vip 3",
                    ROOM_TYPE = "Lớn",
                    PRICE = 300000,
                    CAPACITY = 8,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PHV04",
                    ROOM_NAME = "Phòng vip 4",
                    ROOM_TYPE = "Lớn",
                    PRICE = 300000,
                    CAPACITY = 8,
                    STATUS = "Trống"
                };
                context.ROOMs.Add(room);

                room = new ROOM()
                {
                    ID_ROOM = "PHV05",
                    ROOM_NAME = "Phòng vip 5",
                    ROOM_TYPE = "Lớn",
                    PRICE = 300000,
                    CAPACITY = 8,
                    STATUS = "Có khách"
                };
                context.ROOMs.Add(room);

                context.SaveChanges();
                #endregion

                #region Initialize MENU
                var menu = new MENU()
                {
                    NAME = "pepsi",
                    PRICE = 15000,

                };
                context.MENUs.Add(menu);

                menu = new MENU()
                {
                    NAME = "Coca Cola",
                    PRICE = 15000,

                };
                context.MENUs.Add(menu);

                menu = new MENU()
                {
                    NAME = "Khoai tây chiên",
                    PRICE = 15000,

                };
                context.MENUs.Add(menu);
                context.SaveChanges();
                #endregion

                #region Initialize CUSTOMER
                var customer = new CUSTOMER()
                {
                    CUSTOMER_NAME = "Trần Đức Long",
                    PHONE = "0358867481",
                    EMAIL = "Longdeptraimadeptrai@gmail.com",
                    ID_CARD = "123456789",

                };
                context.CUSTOMERs.Add(customer);

                context.SaveChanges();
                #endregion

                #region Initialize ROOM_ORDER
                var room_order = new ROOM_ORDER()
                {
                    ID_ROOM = "PHV05",
                    ID_CUSTOMER = 1,
                    TIME_IN = DateTime.Now,
                };
                context.ROOM_ORDER.Add(room_order);

                context.SaveChanges();
                #endregion

                #region Initialize ORDERs
                var orders = new ORDER_S()
                {
                    ID_ROOM_ORDER = 1,
                    ID_MENU = 1,
                    QTY = 2,
                    TOTAL_PRICE = 15000,

                };
                context.ORDER_S.Add(orders);

                context.SaveChanges();
                #endregion

                #region Employee
                var employee = new EMPLOYEE()
                {
                    NAME = "Nguyen Minh A",
                    PHONE = "01119998888",
                    EMAIL = "nv1@gmail.com",
                    ID_CARD = "9999",
                    ADDRESS = "1 Võ Văn Ngân, Thu Duc",
                    ROLE_EMOLOYEE = "Nhân viên",
                    DoB = new DateTime(2002, 01, 01),
                    ACCOUNT = new ACCOUNT
                    {
                        ACCOUNT_NAME = "nv02",
                        PASSWORD = "123",
                        ROLE = "employee",
                    }
                };
                context.EMPLOYEEs.Add(employee);

                employee = new EMPLOYEE
                {
                    NAME = "Nguyen B",
                    PHONE = "00112233556",
                    EMAIL = "nv2@gmail.com",
                    ID_CARD = "8888",
                    ADDRESS = "123 Ly Chieu Hoang, Quan 6",
                    ROLE_EMOLOYEE = "Nhân viên",
                    DoB = new DateTime(2001, 09, 09),
                    ACCOUNT = new ACCOUNT
                    {
                        ACCOUNT_NAME = "nv01",
                        PASSWORD = "1232",
                        ROLE = "employee",
                    }
                };
                context.EMPLOYEEs.Add(employee);

                employee = new EMPLOYEE
                {
                    NAME = "Nguyen Tien",
                    PHONE = "00112233556",
                    EMAIL = "nv2@gmail.com",
                    ID_CARD = "123132",
                    ADDRESS = "123123 Nguyen van LUONG, Quan 6",
                    ROLE_EMOLOYEE = "Quản lý",
                    DoB = new DateTime(2001, 09, 09),
                    ACCOUNT = new ACCOUNT
                    {
                        ACCOUNT_NAME = "nv03",
                        PASSWORD = "123",
                        ROLE = "admin",
                    }

                };
                context.EMPLOYEEs.Add(employee);

                #endregion
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
