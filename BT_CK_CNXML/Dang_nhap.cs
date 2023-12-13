using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.Model;

namespace test1
{
    public partial class Form1 : Form
    {
        XMLFile XmlFile = new XMLFile();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Dang_Ky Dang_ky = new Dang_Ky();
            Dang_ky.Show();
        }
     

        private void btDANGNHAP_Click(object sender, EventArgs e)
        {
            Login DN = new Login();
            String check = DN.login(tbTENDANGNHAP.Text, tbMATKHAU.Text);
            if (!check.Equals(""))
            {
                Trang_Chu trang_Chu = new Trang_Chu();
                trang_Chu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo");
            }
        }
    }
}
