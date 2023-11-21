using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.MODELS;

namespace test1
{
    public partial class Form1 : Form
    {
        static public Trang_chủ trangchu;
        public Form1()
        {
            InitializeComponent();
        }

        private void btDANGNHAP_Click(object sender, EventArgs e)
        {
            model_DANGNHAP DN = new model_DANGNHAP();
            String check = DN.Login(tbTENDANGNHAP.Text, tbMATKHAU.Text);
            if (!check.Equals(""))
            {
                trangchu = new Trang_chủ();
                trangchu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo");
            }
            
        }
    }
}
