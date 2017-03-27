using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLST.DT0;
namespace QLST.DAL
{
    class DAO

    {

        //Nhân Viên
        public static DataTable xuat_NV()
        {
            return DataProvider.GetData("get_NV");
        }
        //Khách hàng
        public static DataTable xuat_KH()
        {
            return DataProvider.GetData("get_kh");
        }
        //Hàng Hóa
        public static DataTable xuat_HH()
        {
            return DataProvider.GetData("get_HH");
        }
        public static DataTable xuat_HH1(string ma)
        {
            return DataProvider.GetData("get_HH1" + "'" + ma + "'");
        }
        //Kho
        public static DataTable xuat_Kho()
        {
            return DataProvider.GetData("get_Kho");
        }
        //bán hàng
        public static DataTable xuat_hoadon()
        {
            return DataProvider.GetData("get_hoadon");
        }
        public static DataTable xuat_cthd(string ma)
        {
            return DataProvider.GetData("get_cthd" + "'" + ma + "'");
        }
        public static int them_hoadon(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd", a.Mahd),
                new SqlParameter("@manv", a.Manv),
                new SqlParameter("@makh", a.Makh),
                new SqlParameter("@ngaylap", a.Ngaylap),
                new SqlParameter("@vat", a.Vat),
            

            };
            return DataProvider.ExecuteNonQuery("them_hoadon", para);
        }
        public static int sua_hoadon(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd", a.Mahd),
                new SqlParameter("@manv", a.Manv),
                new SqlParameter("@makh", a.Makh),
                new SqlParameter("@ngaylap", a.Ngaylap),
                new SqlParameter("@vat", a.Vat),
              

            };
            return DataProvider.ExecuteNonQuery("sua_hoadon", para);
        }
        public static int sua_hoadon1(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd", a.Mahd),
                
                new SqlParameter("@tongtien", a.Tongtien),

            };
            return DataProvider.ExecuteNonQuery("luu_tien", para);
        }
        public static int xoa_hoadon(Hoadon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", a.Mahd),


            };
            return DataProvider.ExecuteNonQuery("xoa_hoadon", para);
        }
        public static int them_cthd(ChitietHoaDon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macthd", a.Macthd),
                new SqlParameter("@mahd", a.Mahd),
                new SqlParameter("@mahh", a.Mahh),
                new SqlParameter("@dongia", a.Dongia),
                new SqlParameter("@sl", a.Soluong),
                new SqlParameter("@tien", a.Tien),

            };
            return DataProvider.ExecuteNonQuery("them_cthd", para);
        }
        public static int sua_cthd(ChitietHoaDon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macthd", a.Macthd),
                new SqlParameter("@mahh", a.Mahh),
                new SqlParameter("@dongia", a.Dongia),
                new SqlParameter("@sl", a.Soluong),
                new SqlParameter("@tien", a.Tien),

            };
            return DataProvider.ExecuteNonQuery("sua_cthd", para);
        }
        public static int xoa_cthd(ChitietHoaDon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macthd", a.Macthd),


            };
            return DataProvider.ExecuteNonQuery("xoa_cthd", para);
        }
        //Nhập hàng
        public static DataTable xuat_pn()
        {
            return DataProvider.GetData("get_pn");
        }
        public static DataTable xuat_ctn(string ma)
        {
            return DataProvider.GetData("get_ctn" + "'" + ma + "'");
        }
      
    }
}
