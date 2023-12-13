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
    public partial class Cập_nhật_sao_lưu : Form
    {
        public Cập_nhật_sao_lưu()
        {
            InitializeComponent();
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
