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
    public partial class Quan_Ly_Nhan_Vien : Form
    {
        XMLFile XmlFile = new XMLFile();
        public Quan_Ly_Nhan_Vien()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTenNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxNamsinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxKPI.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxSDT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            catch { }
        }
        void CapNhatBang()
        {
            dataGridView1.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("NhanViens.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/NhanViens/NhanVien");
            foreach (XmlNode x in nodeList)
            {
                dataGridView1.Rows.Add(
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    x.ChildNodes[4].InnerText,
                    x.ChildNodes[3].InnerText,
                    x.ChildNodes[2].InnerText);
            }
        }

        private void Quan_Ly_Nhan_Vien_Load(object sender, EventArgs e)
        {
            CapNhatBang();
        }

        //String tenNV, String KPI, String SoDT, String Namsinh
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTenNV.Text.Equals("") && textBoxKPI.Text.Equals("") && textBoxSDT.Text.Equals("") && textBoxNamsinh.Text.Equals(""))
                {
                    MessageBox.Show("Nhập THiếu Thông Tin \nVui Lòng Nhập Đày Đủ");
                }
                else
                {
                    Quan_ly_nhan_vien kh = new Quan_ly_nhan_vien();

                    if (kh.themNhanVien(textBoxTenNV.Text, textBoxKPI.Text, textBoxSDT.Text, textBoxNamsinh.Text))
                        MessageBox.Show("Thêm Nhân viên Thành Công", "Thông Báo");
                    CapNhatBang();
                }

            }
            catch
            {
                MessageBox.Show("Có gì đó sai sai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quan_ly_nhan_vien kh = new Quan_ly_nhan_vien();

            if (kh.suaThongTinNhanVien(textBoxMaNV.Text, textBoxTenNV.Text, textBoxKPI.Text, textBoxSDT.Text, textBoxNamsinh.Text))
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo");
            else
                MessageBox.Show("Sửa Thông Tin ĐÃ Thất Bại", "Thông Báo");
            CapNhatBang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắc Về Việc Này", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Quan_ly_nhan_vien kh = new Quan_ly_nhan_vien();
                    if (kh.xoaThongTin(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                        CapNhatBang();
                }
                catch { }

            }
        }
    }
}
