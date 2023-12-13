using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test1.Model
{
    class Danh_sach_khach_hang
    {
        XMLFile XmlFile = new XMLFile();

        public Boolean themKhachHang( String tenKH, String DiaChi, String SoDT, String Namsinh)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("KhachHangs.xml");
                XmlElement node = XDoc.CreateElement("KhachHang");
                XmlElement makh = XDoc.CreateElement("MaKH");
                XmlElement TenKH = XDoc.CreateElement("TenKH");
                XmlElement diachi = XDoc.CreateElement("DiaChi");
                XmlElement sdt = XDoc.CreateElement("SDT");
                XmlElement namsinh = XDoc.CreateElement("NamSinh");




                makh.InnerText = taoMaKhachHang(XDoc) ;
                TenKH.InnerText = tenKH;
                diachi.InnerText = DiaChi ;
                sdt.InnerText = SoDT;
                namsinh.InnerText = Namsinh;


                node.AppendChild(makh);
                node.AppendChild(TenKH);
                node.AppendChild(diachi);
                node.AppendChild(sdt);
                node.AppendChild(namsinh);

                XDoc.DocumentElement.AppendChild(node);


                XDoc.Save("KhachHangs.xml");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        String taoMaKhachHang(XmlDocument XDoc)
        {
            XmlNodeList temp = XDoc.SelectNodes("/KhachHangs/KhachHang[last()]");
            String maKH = temp[0].ChildNodes[0].InnerText;
            maKH = ("000" + (int.Parse(maKH.Substring(2)) + 1).ToString());
            maKH = "KH" + maKH.Substring(maKH.Length - 2);
            return maKH;
        }

        public Boolean suaThongTinKhachHang(String maKH, String tenKH, String DiaChi, String SoDT, String Namsinh)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("KhachHangs.xml");
                XmlNodeList nodeList = XDoc.SelectNodes("/KhachHangs/KhachHang[MaKH = '" + maKH + "']");
                XmlNode node = nodeList[0];
                node.ChildNodes[1].InnerText = tenKH;
                node.ChildNodes[2].InnerText = DiaChi;
                node.ChildNodes[3].InnerText = SoDT;
                node.ChildNodes[4].InnerText = Namsinh;

                XDoc.Save("KhachHangs.xml");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Boolean xoaThongTin(String maKH)
        {
            try
            {
                XmlDocument Xdoc = XmlFile.getXmlDocument("KhachHangs.xml");
                XmlNodeList nodeList = Xdoc.SelectNodes("/KhachHangs/KhachHang[MaKH = '"+maKH+"']");
                Xdoc.DocumentElement.RemoveChild(nodeList[0]);
                Xdoc.Save("KhachHangs.xml");
            }
            catch { }
            return true;
        }

    }
}
