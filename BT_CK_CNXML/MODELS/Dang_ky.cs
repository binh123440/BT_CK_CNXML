using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test1.MODELS
{
    class Dang_ky
    {
        model_XMLFile XmlFile = new model_XMLFile();
        public Boolean themTaiKhoan(String ten, String tenDN, String MK)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("TaiKhoans.xml");
                XmlElement node = XDoc.CreateElement("TaiKhoan");
                XmlElement HoTen = XDoc.CreateElement("HoTen");
                XmlElement tenTK = XDoc.CreateElement("TenTK");
                XmlElement MatKhau = XDoc.CreateElement("MatKhau");
                XmlElement maNV = XDoc.CreateElement("MaNV");



                HoTen.InnerText = ten;
                tenTK.InnerText = tenDN;
                MatKhau.InnerText = MK;
                maNV.InnerText = taoMaNhanVien(XDoc);


                node.AppendChild(HoTen);
                node.AppendChild(tenTK);
                node.AppendChild(MatKhau);
                node.AppendChild(maNV);

                XDoc.DocumentElement.AppendChild(node);


                XDoc.Save("TaiKhoans.xml");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        String taoMaNhanVien(XmlDocument XDoc)
        {
            XmlNodeList temp = XDoc.SelectNodes("/TaiKhoans/TaiKhoan[last()]");
            String maNV = temp[0].ChildNodes[2].InnerText;
            maNV = ("000" + (int.Parse(maNV.Substring(2)) + 1).ToString());
            maNV = "NV" + maNV.Substring(maNV.Length - 2);
            return maNV;
        }
    }

}