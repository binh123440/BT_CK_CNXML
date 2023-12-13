using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Trang_Chu : Form
    {
        public Trang_Chu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quan_Ly_Kho_Hang quan_Ly_Kho_Hang = new Quan_Ly_Kho_Hang();
            quan_Ly_Kho_Hang.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cap_Nhat_Sao_Luu cap_Nhat_Sao_Luu = new Cap_Nhat_Sao_Luu();
            cap_Nhat_Sao_Luu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Danh_Sach_Don_Hang danh_Sach_Don_Hang = new Danh_Sach_Don_Hang();
            danh_Sach_Don_Hang.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quan_Ly_Nhan_Vien quan_Ly_Nhan_Vien = new Quan_Ly_Nhan_Vien();
            quan_Ly_Nhan_Vien.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quan_Ly_Khach_Hang quan_Ly_Khach_Hang = new Quan_Ly_Khach_Hang();
            quan_Ly_Khach_Hang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tao_Don_Hang tao_Don_Hang = new Tao_Don_Hang();
            tao_Don_Hang.Show();
        }
    }
}
