using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.Model
{
    class SQL2XML
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FFPILQ6\SQLEXPRESS;Initial Catalog=dbQuanLyBanDienThoai;Integrated Security=True;");
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
                ds.WriteXml(  XMLName + "s" + ".xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
