using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using test1.Model;

namespace test1
{
    public partial class Danh_Sach_Don_Hang : Form
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        public Danh_Sach_Don_Hang()
        {
            InitializeComponent();
        }
        void CapNhatBang()
        {
            String maKH;
            String maNV;
            stt = 0;
            dataGridView2.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("DonHangs.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/DonHangs/DonHang");
            foreach (XmlNode x in nodeList)
                
            {
                maKH = x.ChildNodes[2].InnerText;
                XmlDocument XDoc2 = XmlFile.getXmlDocument("KhachHangs.xml");
                XmlNode node = XDoc2.SelectSingleNode("/KhachHangs/KhachHang[MaKH = '" + maKH + "']/TenKH");
                string tenKH = node.InnerText;

                maNV = x.ChildNodes[3].InnerText;
                XmlDocument XDoc3 = XmlFile.getXmlDocument("NhanViens.xml");
                XmlNode node2 = XDoc3.SelectSingleNode("/NhanViens/NhanVien[MaNV = '" + maNV + "']/TenNV");
                string tenNV = node2.InnerText;

                dataGridView2.Rows.Add(++stt,
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    tenKH,
                    tenNV);


            }

            //node.ChildNodes[1].InnerText = tenNV;


           

        }
        void CapNhatBang2(string MADH)
        {
            int stt = 0;
            dataGridView1.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietDonHangs.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/ChiTietDonHangs/ChiTietDonHang[MaDH='" + MADH + "']");
            foreach (XmlNode x in nodeList)

            {
                XmlDocument XDoc2 = XmlFile.getXmlDocument("DienThoais.xml");
                XmlNode dienThoai = XDoc2.SelectSingleNode("/DienThoais/DienThoai[MaDT = '" + x.ChildNodes[1].InnerText + "']");
                dataGridView1.Rows.Add(++stt,
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    dienThoai.ChildNodes[1].InnerText,
                    x.ChildNodes[2].InnerText,
                    dienThoai.ChildNodes[3].InnerText,
                    Convert.ToInt32(dienThoai.ChildNodes[3].InnerText) * Convert.ToInt32(x.ChildNodes[2].InnerText)
                    );
            }

        }

        XmlNodeList nodeListDM;
        private void Danh_Sach_Don_Hang_Load(object sender, EventArgs e)
        {
            CapNhatBang();
            Danh_sach_don_hang DMSP = new Danh_sach_don_hang();
            nodeListDM = DMSP.getListMD();
            foreach (XmlNode x in nodeListDM)
            {
                comboBoxMaDH.Items.Add(x.ChildNodes[0].InnerText);

            }
            Danh_sach_don_hang DMNV = new Danh_sach_don_hang();
            nodeListDM = DMSP.getListMD2();
            foreach (XmlNode x in nodeListDM)
            {
                comboBoxTenNV.Items.Add(x.ChildNodes[1].InnerText);
            }
            Danh_sach_don_hang DMKH = new Danh_sach_don_hang();
            nodeListDM = DMKH.getListMD3();
            foreach (XmlNode x in nodeListDM)
            {
                comboBoxTenKH.Items.Add(x.ChildNodes[1].InnerText);
            }


        }
        private void dataGridView2_MouseCaptureChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxMaDH.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                comboBoxTenKH.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                comboBoxTenNV.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }
            CapNhatBang2(comboBoxMaDH.Text);
        }

        private void comboBoxMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatBang2(comboBoxMaDH.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Danh_sach_don_hang kh = new Danh_sach_don_hang();

            if (kh.suaThongTinDonHang(comboBoxTenKH.Text, comboBoxTenNV.Text, comboBoxMaDH.Text))
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo");
            else
                MessageBox.Show("Sửa Thông Tin ĐÃ Thất Bại", "Thông Báo");
            CapNhatBang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắc Về Việc Này", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Danh_sach_don_hang kh = new Danh_sach_don_hang();
                    if (kh.xoaThongTin(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
                        CapNhatBang();
                }
                catch { }

            }
        }
    }
}
