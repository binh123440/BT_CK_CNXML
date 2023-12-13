using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test1.Model
{
    class Login
    {
        XMLFile XmlFile = new XMLFile();

        public String login(String userName, string password)
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("TaiKhoans.xml");
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
