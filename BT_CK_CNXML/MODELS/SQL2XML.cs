using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace test1.MODELS
{
    class SQL2XML
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8H3JR7M\SQLEXPRESS;Initial Catalog=dbQuanLyBanDienThoai;Integrated Security=True;");
        public void RestoreData()
        {
            RestoreData("select * from NhanVien", "NhanVien");
            RestoreData("select * from KhachHang", "KhachHang");
            RestoreData("select * from TaiKhoan", "TaiKhoan");
            RestoreData("select * from DienThoai", "DienThoai");
            RestoreData("select * from DonHang", "DonHang");
            RestoreData("select * from ChiTietDonHang", "ChiTietDonHang");
        }
        public void RestoreData(String query, String XMLName)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(query, conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, XMLName);
                ds.DataSetName = XMLName + "s";
                ds.WriteXml(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\" + XMLName + "s" + ".xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
