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
    public partial class Cap_Nhat_Sao_Luu : Form
    {
        public Cap_Nhat_Sao_Luu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_XML2SQL_Click(object sender, EventArgs e)
        {
            XML2SQL bk = new XML2SQL();
            bk.BackUpData();
            MessageBox.Show("Đã sao lưu lên máy chủ", "Thành công!");
        }

        private void btn_SQL2XML_Click(object sender, EventArgs e)
        {
            SQL2XML rs = new SQL2XML();
            rs.RestoreData();
            MessageBox.Show("Đã khôi phục dữ liệu từ máy chủ", "Thành công!");
        }
    }
}
