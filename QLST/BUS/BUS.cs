using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLST.DAL;
using QLST.DT0;
namespace QLST.BUS
{
    class BUS
    {
        //Nhân viên
        public static DataTable xuat_NV()
        {
            return DAO.xuat_NV();
        }
        //Khách hàng
        public static DataTable xuat_KH()
        {
            return DAO.xuat_KH();
        }
        //Hàng Hóa
        public static DataTable xuat_HH()
        {
            return DAO.xuat_HH();
        }
        public static DataTable xuat_HH1(string ma)
        {
            return DAO.xuat_HH1(ma);
        }
        //Kho
        public static DataTable xuat_Kho()
        {
            return DAO.xuat_Kho();
        }
        //Bán hàng
        public static DataTable xuat_hoadon()
        {
            return DAO.xuat_hoadon();
        }

        public static DataTable xuat_cthd(string ma)
        {
            return DAO.xuat_cthd(ma);

        }
        //Nhập hàng
        public static DataTable xuat_pn()
        {
            return DAO.xuat_pn();
        }

        public static DataTable xuat_ctn(string ma)
        {
            return DAO.xuat_ctn(ma);

        }
    }
}
