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
        //Thong ke
        public static DataTable tk_hh()
        {
            return DataProvider.GetData("tkhh");
        }
        public static DataTable tk_ban()
        {
            return DataProvider.GetData("tk_ban");

        }
        public static DataTable tk_nhap()
        {
            return DataProvider.GetData("tk_nhap");
        }

        //Nhân Viên
        public static DataTable xuat_NV()
        {
            return DataProvider.GetData("get_NV");
        }
        public static int them_nv(Nhanvien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
                new SqlParameter("@tennv", a.TenNV),
                new SqlParameter("@chucvu", a.Chucvu),
                new SqlParameter("@gt", a.Gioitinh),
                new SqlParameter("@diachi", a.Diachi),
                new SqlParameter("@sdt", a.Sdt),

            };
            return DataProvider.ExecuteNonQuery("them_nv", para);
        }
        public static int sua_nv(Nhanvien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
                new SqlParameter("@tennv", a.TenNV),
                new SqlParameter("@chucvu", a.Chucvu),
                new SqlParameter("@gt", a.Gioitinh),
                new SqlParameter("@diachi", a.Diachi),
                new SqlParameter("@sdt", a.Sdt),

            };
            return DataProvider.ExecuteNonQuery("sua_nv", para);
        }
        public static int xoa_nv(Nhanvien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
                

            };
            return DataProvider.ExecuteNonQuery("xoa_nv", para);
        }
        //Khách hàng
        public static DataTable xuat_KH()
        {
            return DataProvider.GetData("get_kh");
        }
        public static int them_kh(Khachhang a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", a.Makh),
                new SqlParameter("@tenkh", a.Tenkh),
                new SqlParameter("@diachi", a.Diachi),
                new SqlParameter("@gt", a.Gioitinh),
                new SqlParameter("@sdt", a.Sdt),
                new SqlParameter("@diem", a.Diem),

            };
            return DataProvider.ExecuteNonQuery("them_kh", para);
        }
        public static int sua_kh(Khachhang a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", a.Makh),
                new SqlParameter("@tenkh", a.Tenkh),
                new SqlParameter("@diachi", a.Diachi),
                new SqlParameter("@gt", a.Gioitinh),
                new SqlParameter("@sdt", a.Sdt),
                new SqlParameter("@diem", a.Diem),

            };
            return DataProvider.ExecuteNonQuery("sua_kh", para);
        }
        public static int xoa_kh(Khachhang a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh", a.Makh),
                

            };
            return DataProvider.ExecuteNonQuery("xoa_kh", para);
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
        public static DataTable xuat_HH2(float a,float b)
        {
            return DataProvider.GetData("get_HH2" + a +","+b);
        }
        public static DataTable xuat_HH3(string a)
        {
            return DataProvider.GetData("get_HH3" + "'" + a + "'");
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
                new SqlParameter("@tongtien", a.Tongtien),

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
        public static int them_pn(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.Mapn),
                new SqlParameter("@mathukho", a.Mathukho),
                new SqlParameter("@makho", a.Makho),
                new SqlParameter("@ngaylap", a.Ngaylap),
                new SqlParameter("@vat", a.Vat),
                new SqlParameter("@tongtien", a.Tongtien),

            };
            return DataProvider.ExecuteNonQuery("them_pn", para);
        }
        public static int sua_pn(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.Mapn),
                new SqlParameter("@mathukho", a.Mathukho),
                new SqlParameter("@makho", a.Makho),
                new SqlParameter("@ngaylap", a.Ngaylap),
                new SqlParameter("@vat", a.Vat),


            };
            return DataProvider.ExecuteNonQuery("sua_pn", para);
        }
        public static int sua_pn1(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.Mapn),

                new SqlParameter("@tongtien", a.Tongtien),

            };
            return DataProvider.ExecuteNonQuery("luu_tien_nhap", para);
        }
        public static int xoa_pn(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.Mapn),


            };
            return DataProvider.ExecuteNonQuery("xoa_pn", para);
        }
        //Chi tiết nhập
        public static int them_ctn (Chitietnhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mactn", a.Mactn),
                new SqlParameter("@mapn", a.Mapn),
                new SqlParameter("@mahh", a.Mahh),
                new SqlParameter("@dongia", a.Dongia),
                new SqlParameter("@soluong", a.Soluong),
                new SqlParameter("@tien", a.Tien),

            };
            return DataProvider.ExecuteNonQuery("them_ctn", para);
        }
        public static int sua_ctn(Chitietnhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mactn", a.Mactn),
                new SqlParameter("@mahh", a.Mahh),
                new SqlParameter("@dongia", a.Dongia),
                new SqlParameter("@soluong", a.Soluong),
                new SqlParameter("@tien", a.Tien),

            };
            return DataProvider.ExecuteNonQuery("sua_ctn", para);
        }
        public static int xoa_ctn(Chitietnhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mactn", a.Mactn),


            };
            return DataProvider.ExecuteNonQuery("xoa_ctn", para);
        }

    }
}
