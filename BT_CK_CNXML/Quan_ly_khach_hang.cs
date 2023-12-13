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
    public partial class Quan_Ly_Khach_Hang : Form
    {
        XMLFile XmlFile = new XMLFile();
        public Quan_Ly_Khach_Hang()
        {
            InitializeComponent();
        }

        void CapNhatBang()
        {
            dataGridView1.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("KhachHangs.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/KhachHangs/KhachHang");
            foreach (XmlNode x in nodeList)
            {
                dataGridView1.Rows.Add(
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    x.ChildNodes[2].InnerText,
                    x.ChildNodes[3].InnerText,
                    x.ChildNodes[4].InnerText);
            }

        }

        private void Quan_Ly_Khach_Hang_Load(object sender, EventArgs e)
        {
            CapNhatBang();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTenKH.Text.Equals("") && textBoxNamSinh.Text.Equals("") && textBoxDiaChi.Text.Equals("") && textBoxSDT.Text.Equals(""))
                {
                    MessageBox.Show("Nhập THiếu Thông Tin \nVui Lòng Nhập Đày Đủ");
                }
                else
                {
                    Danh_sach_khach_hang kh = new Danh_sach_khach_hang();

                    if (kh.themKhachHang(textBoxTenKH.Text, textBoxDiaChi.Text, textBoxSDT.Text, textBoxNamSinh.Text))
                        MessageBox.Show("Thêm Khách Hàng Thành Công", "Thông Báo");
                        CapNhatBang();
                }

            }
            catch
            {
                MessageBox.Show("Có gì đó sai sai");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Danh_sach_khach_hang kh = new Danh_sach_khach_hang();

            if (kh.suaThongTinKhachHang(textBoxMaKH.Text, textBoxTenKH.Text, textBoxDiaChi.Text, textBoxSDT.Text, textBoxNamSinh.Text))
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo");
            else
                MessageBox.Show("Sửa Thông Tin ĐÃ Thất Bại", "Thông Báo");
            CapNhatBang();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắc Về Việc Này", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Danh_sach_khach_hang kh = new Danh_sach_khach_hang();
                    if (kh.xoaThongTin(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                        CapNhatBang();
                }
                catch { }

            }

        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {            
                try
                {
                textBoxMaKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxNamSinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                
                }
                catch { }
        }
    }
    
}
