using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test1.MODELS
{
    class model_DANGNHAP
    {
        model_XMLFile XmlFile = new model_XMLFile();

        public String Login(String userName, string password)
        {
            XmlDocument XDoc = XmlFile.getXmlDocument(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\TaiKhoans.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/TaiKhoans/TaiKhoan[TenTK = '" + userName + "']");

            if (nodeList.Count != 0)
            {
                if (nodeList[0].SelectSingleNode("MatKhau").InnerText.Equals(password))
                {
                    return nodeList[0].SelectSingleNode("MaNV").InnerText;
                    // testing 
                }
                else
                {
                    return "";
                }
            }

            return "";

        }
    }
}

