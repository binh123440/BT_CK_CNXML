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
            
        }
    }
}
