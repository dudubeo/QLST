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
        public static int them_nv(Nhanvien a)
        {
            return DAO.them_nv(a);
        }
        public static int sua_nv(Nhanvien a)
        {
            return DAO.sua_nv(a);
        }
        public static int xoa_nv(Nhanvien a)
        {
            return DAO.xoa_nv(a);
        }
        //Khách hàng
        public static DataTable xuat_KH()
        {
            return DAO.xuat_KH();
        }
        public static int them_kh(Khachhang a)
        {
            return DAO.them_kh(a);
        }
        public static int sua_kh(Khachhang a)
        {
            return DAO.sua_kh(a);
        }
        public static int xoa_kh(Khachhang a)
        {
            return DAO.xoa_kh(a);
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
        public static DataTable xuat_HH2(float a,float b)
        {
            return DAO.xuat_HH2(a,b);
        }
        public static DataTable xuat_HH3(string a)
        {
            return DAO.xuat_HH3(a);
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


        public static int them_pn(PhieuNhap a)
        {
            return DAO.them_pn(a);
        }
        public static int sua_pn(PhieuNhap a)
        {
            return DAO.sua_pn(a);
        }
        public static int sua_pn1(PhieuNhap a)
        {
            return DAO.sua_pn1(a);
        }
        public static int xoa_pn(PhieuNhap a)
        {
            return DAO.xoa_pn(a);
        }
        public static int them_ctn(Chitietnhap a)
        {
            return DAO.them_ctn(a);
        }
        public static int sua_ctn(Chitietnhap a)
        {
            return DAO.sua_ctn(a);
        }
        public static int xoa_ctn(Chitietnhap a)
        {
            return DAO.xoa_ctn(a);

        }
    }
}
