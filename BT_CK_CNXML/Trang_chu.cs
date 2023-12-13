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
    public partial class Trang_chủ : Form
    {
        public Trang_chủ()
        {
            InitializeComponent();
        }

        private void btn_tao_don_hang_Click(object sender, EventArgs e)
        {
            Thanh_toán thanh_toan = new Thanh_toán();
            thanh_toan.Show();
        }

        private void btn_cap_nhat_sao_luu_Click(object sender, EventArgs e)
        {
            Cập_nhật_sao_lưu cap_nhat_sao_luu = new Cập_nhật_sao_lưu();
            cap_nhat_sao_luu.Show();
        }

        private void btn_quan_ly_kho_hang_Click(object sender, EventArgs e)
        {
            Quản_lý_kho_hàng quan_ly_kho_hang = new Quản_lý_kho_hàng();
            quan_ly_kho_hang.Show();
        }

        private void btn_danh_sach_don_hang_Click(object sender, EventArgs e)
        {
            Danh_sách_đơn_hàng danh_sach_don_hang = new Danh_sách_đơn_hàng();
            danh_sach_don_hang.Show();
        }

        private void btn_quan_ly_nhan_vien_Click(object sender, EventArgs e)
        {
            Quản_lý_nhân_viên quan_ly_nhan_vien = new Quản_lý_nhân_viên();
            quan_ly_nhan_vien.Show();
        }

        private void btn_quan_ly_khach_hang_Click(object sender, EventArgs e)
        {
            Quản_lý_khách_hàng quan_ly_khach_hang = new Quản_lý_khách_hàng();
            quan_ly_khach_hang.Show();
        }
    }
}
