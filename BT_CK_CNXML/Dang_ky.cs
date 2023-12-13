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
    public partial class Dang_Ky : Form
    {
        XMLFile XmlFile = new XMLFile();
        public Dang_Ky()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxHoTen.Text.Equals("") && textBoxTenDN.Text.Equals("") && textBoxMK.Text.Equals(""))
                {
                    MessageBox.Show("Nhập THiếu Thông Tin \nVui Lòng Nhập Đày Đủ");
                    Trang_Chu trang_Chu = new Trang_Chu();
                    trang_Chu.Show();
                }
                else
                {
                    Dang_ky dk = new Dang_ky();
                    if (dk.themTaiKhoan(textBoxHoTen.Text, textBoxTenDN.Text, textBoxMK.Text))
                    {//textBoxHoTen.Text,
                        MessageBox.Show("Đăng Ký Thành Công", "Thông Báo");
                        Trang_Chu trang_Chu = new Trang_Chu();
                        trang_Chu.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có gì đó sai sai");
                Trang_Chu trang_Chu = new Trang_Chu();
                trang_Chu.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
