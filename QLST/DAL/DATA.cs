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
