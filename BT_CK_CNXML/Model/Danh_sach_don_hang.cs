using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test1.Model
{
    class Danh_sach_don_hang
    {
        XMLFile XmlFile = new XMLFile();


        public XmlNodeList getListMD()
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("DonHangs.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/DonHangs/DonHang");
            for (int i = 0; i < nodeList.Count; i++)
            {
                XmlNode a = nodeList[i];
            }
            return nodeList;
        }

        public XmlNodeList getListMD2()
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("NhanViens.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/NhanViens/NhanVien");
            for (int i = 0; i < nodeList.Count; i++)
            {
                XmlNode a = nodeList[i];


            }
            return nodeList;


        }
        public XmlNodeList getListMD3()
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("KhachHangs.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/KhachHangs/KhachHang");
            for (int i = 0; i < nodeList.Count; i++)
            {
                XmlNode a = nodeList[i];


            }
            return nodeList;


        }

        public Boolean suaThongTinDonHang(String tenKH, String tenNV, String maDH)
        {
            try
            {
                XmlDocument XDoc2 = XmlFile.getXmlDocument("NhanViens.xml");
                XmlNode node = XDoc2.SelectSingleNode("/NhanViens/NhanVien[TenNV = '" + tenNV + "']/MaNV");
                string manv = node.InnerText;

                XmlDocument XDoc3 = XmlFile.getXmlDocument("KhachHangs.xml");
                XmlNode node3 = XDoc3.SelectSingleNode("/KhachHangs/KhachHang[TenKH = '" + tenKH + "']/MaKH");
                string makh = node3.InnerText;


                XmlDocument XDoc = XmlFile.getXmlDocument("DonHangs.xml");
                XmlNodeList nodeList = XDoc.SelectNodes("/DonHangs/DonHang[MaDH = '" + maDH + "']");
                XmlNode node2 = nodeList[0];
                node2.ChildNodes[0].InnerText = maDH;
                //node.ChildNodes[1].InnerText = KPI;
                node2.ChildNodes[2].InnerText = makh;
                node2.ChildNodes[3].InnerText = manv;

                XDoc.Save("DonHangs.xml");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Boolean xoaThongTin(String maDH)
        {
            try
            {
                XmlDocument Xdoc = XmlFile.getXmlDocument("DonHangs.xml");
                XmlNodeList nodeList = Xdoc.SelectNodes("/DonHangs/DonHang[MaDH = '" + maDH + "']");
                Xdoc.DocumentElement.RemoveChild(nodeList[0]);
                Xdoc.Save("DonHangs.xml");
            }
            catch { }
            return true;
        }
    }
}
