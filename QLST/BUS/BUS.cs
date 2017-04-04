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
        public static int them_hoadon(Hoadon a)
        {
            return DAO.them_hoadon(a);
        }
        public static int sua_hoadon(Hoadon a)
        {
            return DAO.sua_hoadon(a);
        }
        public static int sua_hoadon1(Hoadon a)
        {
            return DAO.sua_hoadon1(a);
        }
        public static int xoa_hoadon(Hoadon a)
        {
            return DAO.xoa_hoadon(a);
        }
        public static int them_cthd(ChitietHoaDon a)
        {
            return DAO.them_cthd(a);
        }
        public static int sua_cthd(ChitietHoaDon a)
        {
            return DAO.sua_cthd(a);
        }
        public static int xoa_cthd(ChitietHoaDon a)
        {
            return DAO.xoa_cthd(a);
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

        //thong ke
        public static DataTable tk_hh()
        {
            return DAO.tk_hh();

        }
        public static DataTable tk_ban()
        {
            return DAO.tk_ban();

        }
        public static DataTable tk_nhap()
        {
            return DAO.tk_nhap();

        }
    }
}
