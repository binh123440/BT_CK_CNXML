using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test1.MODELS
{
    class XML2SQL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8H3JR7M\SQLEXPRESS;Initial Catalog=dbQuanLyBanDienThoai;Integrated Security=True;");

        // Cái này là overload                             
        public void BackUpData()
        { 
            BackUpData("NhanVien");
            BackUpData("KhachHang");
            BackUpData("DonHang");
            BackUpData("DienThoai");
            BackUpData("TaiKhoan");
            BackUpData("ChiTietDonHang");
        }

        string ToString(XElement elm)
        {
            string result = "";
            foreach (XElement x in elm.Elements())
            {
                if (x == elm.LastNode)
                    result += "N'" + x.Value + "'";
                else
                {
                    result += "N'" + x.Value + "',";
                }
            }
            return "(" + result + ")";
        }

        // Cái này là overload    
        private void BackUpData(string XMLFileName)
        {
            if (XMLFileName.Equals("NhanVien"))
            {
                XDocument XDoc = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\" + XMLFileName + "s.xml");
                conn.Open();
                SqlCommand command;
                // Tạo chuỗi câu lệnh
                String query = "DELETE FROM TaiKhoan;\n " +
                               "DELETE FROM ChiTietDonHang;\n" +
                               "DELETE FROM DonHang;\n";

                query += "DELETE FROM " + XMLFileName + ";\n";

                try
                {
                    foreach (XElement x in XDoc.Descendants(XMLFileName))
                    {
                        query += "INSERT INTO " + XMLFileName + " VALUES" + ToString(x) + ";\n";
                    }

                    // Tạo xong là chạy như bình thường như chạy 1 câu trong SSMS
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    // try catch để biết lỗi
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (XMLFileName.Equals("KhachHang"))
            {
                XDocument XDoc = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\" + XMLFileName + "s.xml");
                conn.Open();
                SqlCommand command;
                // Tạo chuỗi câu lệnh
                String query = "DELETE FROM ChiTietDonHang;\n" +
                               "DELETE FROM DonHang;\n";

                query += "DELETE FROM " + XMLFileName + ";\n";

                try
                {
                    foreach (XElement x in XDoc.Descendants(XMLFileName))
                    {
                        query += "INSERT INTO " + XMLFileName + " VALUES" + ToString(x) + ";\n";
                    }

                    // Tạo xong là chạy như bình thường như chạy 1 câu trong SSMS
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    // try catch để biết lỗi
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (XMLFileName.Equals("DonHang"))
            {
                XDocument XDoc = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\" + XMLFileName + "s.xml");
                conn.Open();
                SqlCommand command;
                // Tạo chuỗi câu lệnh
                String query = "DELETE FROM ChiTietDonHang;\n";

                query += "DELETE FROM " + XMLFileName + ";\n";

                try
                {
                    foreach (XElement x in XDoc.Descendants(XMLFileName))
                    {
                        query += "INSERT INTO " + XMLFileName + " VALUES" + ToString(x) + ";\n";
                    }

                    // Tạo xong là chạy như bình thường như chạy 1 câu trong SSMS
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    // try catch để biết lỗi
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                XDocument XDoc = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\" + XMLFileName + "s.xml");
                conn.Open();
                SqlCommand command;
                // Tạo chuỗi câu lệnh
                String query = "DELETE FROM " + XMLFileName + ";\n";

                try
                {
                    foreach (XElement x in XDoc.Descendants(XMLFileName))
                    {
                        query += "INSERT INTO " + XMLFileName + " VALUES" + ToString(x) + ";\n";
                    }

                    // Tạo xong là chạy như bình thường như chạy 1 câu trong SSMS
                    command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    // try catch để biết lỗi
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

    }

}
