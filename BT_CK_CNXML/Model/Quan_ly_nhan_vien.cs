using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test1.Model
{
    class Quan_ly_nhan_vien
    {
        XMLFile XmlFile = new XMLFile();

        public Boolean themNhanVien(String tenNV, String KPI, String SoDT, String Namsinh)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("NhanViens.xml");
                XmlElement node = XDoc.CreateElement("NhanVien");
                XmlElement manv = XDoc.CreateElement("MaNV");
                XmlElement Tennv = XDoc.CreateElement("TenNV");
                XmlElement kpi = XDoc.CreateElement("KPI");
                XmlElement sdt = XDoc.CreateElement("SDT");
                XmlElement namsinh = XDoc.CreateElement("NamSinh");

                manv.InnerText = taoMaKhachHang(XDoc);
                Tennv.InnerText = tenNV;
                kpi.InnerText = KPI;
                sdt.InnerText = SoDT;
                namsinh.InnerText = Namsinh;

                node.AppendChild(manv);
                node.AppendChild(Tennv);
                node.AppendChild(kpi);
                node.AppendChild(sdt);
                node.AppendChild(namsinh);

                XDoc.DocumentElement.AppendChild(node);

                XDoc.Save("NhanViens.xml");
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
            XmlNodeList temp = XDoc.SelectNodes("/NhanViens/NhanVien[last()]");
            String manv = temp[0].ChildNodes[0].InnerText;
            manv = ("000" + (int.Parse(manv.Substring(2)) + 1).ToString());
            manv = "NV" + manv.Substring(manv.Length - 2);
            return manv;
        }

        public Boolean suaThongTinNhanVien(String maNV, String tenNV, String KPI, String SoDT, String Namsinh)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("NhanViens.xml");
                XmlNodeList nodeList = XDoc.SelectNodes("/NhanViens/NhanVien[MaNV = '" + maNV + "']");
                XmlNode node = nodeList[0];
                node.ChildNodes[1].InnerText = tenNV;
                node.ChildNodes[2].InnerText = KPI;
                node.ChildNodes[3].InnerText = SoDT;
                node.ChildNodes[4].InnerText = Namsinh;

                XDoc.Save("NhanViens.xml");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Boolean xoaThongTin(String maNV)
        {
            try
            {
                XmlDocument Xdoc = XmlFile.getXmlDocument("NhanViens.xml");
                XmlNodeList nodeList = Xdoc.SelectNodes("/NhanViens/NhanVien[MaNV = '" + maNV + "']");
                Xdoc.DocumentElement.RemoveChild(nodeList[0]);
                Xdoc.Save("NhanViens.xml");
            }
            catch { }
            return true;
        }
    }
}
