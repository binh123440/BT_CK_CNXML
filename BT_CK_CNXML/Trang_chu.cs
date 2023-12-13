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
        static public Thanh_toán thanh_toan;
        static public Cập_nhật_sao_lưu cap_nhat_sao_luu;
        public Trang_chủ()
        {
            InitializeComponent();
        }

        private void btn_tao_don_hang_Click(object sender, EventArgs e)
        {
            thanh_toan = new Thanh_toán();
            thanh_toan.Show();
        }

        private void btn_cap_nhat_sao_luu_Click(object sender, EventArgs e)
        {
            cap_nhat_sao_luu = new Cập_nhật_sao_lưu();
            cap_nhat_sao_luu.Show();
        }
    }
}
