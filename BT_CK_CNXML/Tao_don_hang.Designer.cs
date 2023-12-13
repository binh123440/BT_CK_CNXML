
namespace test1
{
    partial class Thanh_toán
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_giohang_in_donhang = new System.Windows.Forms.DataGridView();
            this.donhang_tensp_giohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_masp_giohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_soluong_giohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_dongia_giohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_tongtien_giohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_donhang_soluongdat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_donhang_them = new System.Windows.Forms.Button();
            this.picBox_donhang_anhsp = new System.Windows.Forms.PictureBox();
            this.dataGridView_khohang_in_donhang = new System.Windows.Forms.DataGridView();
            this.donhang_masp_khohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_tensp_khohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_chitiet_khohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_soluongcon_khohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang_dongia_khohang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xacnhan_giohang = new System.Windows.Forms.Button();
            this.cb_manv_donhang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_xoa_giohang = new System.Windows.Forms.Button();
            this.lb_tongtien_giohang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_makh_donhang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_madh_donhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giohang_in_donhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_donhang_anhsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khohang_in_donhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_giohang_in_donhang
            // 
            this.dataGridView_giohang_in_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_giohang_in_donhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donhang_tensp_giohang,
            this.donhang_masp_giohang,
            this.donhang_soluong_giohang,
            this.donhang_dongia_giohang,
            this.donhang_tongtien_giohang});
            this.dataGridView_giohang_in_donhang.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_giohang_in_donhang.Name = "dataGridView_giohang_in_donhang";
            this.dataGridView_giohang_in_donhang.Size = new System.Drawing.Size(603, 261);
            this.dataGridView_giohang_in_donhang.TabIndex = 5;
            // 
            // donhang_tensp_giohang
            // 
            this.donhang_tensp_giohang.HeaderText = "Tên sản phẩm";
            this.donhang_tensp_giohang.Name = "donhang_tensp_giohang";
            // 
            // donhang_masp_giohang
            // 
            this.donhang_masp_giohang.HeaderText = "Mã sản phẩm";
            this.donhang_masp_giohang.Name = "donhang_masp_giohang";
            this.donhang_masp_giohang.Width = 70;
            // 
            // donhang_soluong_giohang
            // 
            this.donhang_soluong_giohang.HeaderText = "SL";
            this.donhang_soluong_giohang.Name = "donhang_soluong_giohang";
            this.donhang_soluong_giohang.Width = 70;
            // 
            // donhang_dongia_giohang
            // 
            this.donhang_dongia_giohang.HeaderText = "Đơn giá";
            this.donhang_dongia_giohang.Name = "donhang_dongia_giohang";
            this.donhang_dongia_giohang.Width = 70;
            // 
            // donhang_tongtien_giohang
            // 
            this.donhang_tongtien_giohang.HeaderText = "Tổng tiền";
            this.donhang_tongtien_giohang.Name = "donhang_tongtien_giohang";
            this.donhang_tongtien_giohang.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_donhang_soluongdat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_donhang_them);
            this.groupBox1.Controls.Add(this.picBox_donhang_anhsp);
            this.groupBox1.Controls.Add(this.dataGridView_khohang_in_donhang);
            this.groupBox1.Location = new System.Drawing.Point(29, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 313);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kho hàng";
            // 
            // tb_donhang_soluongdat
            // 
            this.tb_donhang_soluongdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_donhang_soluongdat.Location = new System.Drawing.Point(1028, 144);
            this.tb_donhang_soluongdat.Name = "tb_donhang_soluongdat";
            this.tb_donhang_soluongdat.Size = new System.Drawing.Size(121, 23);
            this.tb_donhang_soluongdat.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(961, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Số lượng";
            // 
            // btn_donhang_them
            // 
            this.btn_donhang_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_donhang_them.Location = new System.Drawing.Point(993, 211);
            this.btn_donhang_them.Name = "btn_donhang_them";
            this.btn_donhang_them.Size = new System.Drawing.Size(116, 53);
            this.btn_donhang_them.TabIndex = 37;
            this.btn_donhang_them.Text = "Thêm vào giỏ hàng";
            this.btn_donhang_them.UseVisualStyleBackColor = true;
            this.btn_donhang_them.Click += new System.EventHandler(this.btn_donhang_them_Click);
            // 
            // picBox_donhang_anhsp
            // 
            this.picBox_donhang_anhsp.Location = new System.Drawing.Point(626, 19);
            this.picBox_donhang_anhsp.Name = "picBox_donhang_anhsp";
            this.picBox_donhang_anhsp.Size = new System.Drawing.Size(307, 285);
            this.picBox_donhang_anhsp.TabIndex = 36;
            this.picBox_donhang_anhsp.TabStop = false;
            // 
            // dataGridView_khohang_in_donhang
            // 
            this.dataGridView_khohang_in_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khohang_in_donhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donhang_masp_khohang,
            this.donhang_tensp_khohang,
            this.donhang_chitiet_khohang,
            this.donhang_soluongcon_khohang,
            this.donhang_dongia_khohang});
            this.dataGridView_khohang_in_donhang.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_khohang_in_donhang.Name = "dataGridView_khohang_in_donhang";
            this.dataGridView_khohang_in_donhang.Size = new System.Drawing.Size(603, 285);
            this.dataGridView_khohang_in_donhang.TabIndex = 5;
            // 
            // donhang_masp_khohang
            // 
            this.donhang_masp_khohang.HeaderText = "Mã sản phẩm";
            this.donhang_masp_khohang.Name = "donhang_masp_khohang";
            // 
            // donhang_tensp_khohang
            // 
            this.donhang_tensp_khohang.HeaderText = "Tên sản phẩm";
            this.donhang_tensp_khohang.Name = "donhang_tensp_khohang";
            // 
            // donhang_chitiet_khohang
            // 
            this.donhang_chitiet_khohang.HeaderText = "Chi tiết";
            this.donhang_chitiet_khohang.Name = "donhang_chitiet_khohang";
            // 
            // donhang_soluongcon_khohang
            // 
            this.donhang_soluongcon_khohang.HeaderText = "SL còn";
            this.donhang_soluongcon_khohang.Name = "donhang_soluongcon_khohang";
            // 
            // donhang_dongia_khohang
            // 
            this.donhang_dongia_khohang.HeaderText = "Đơn giá";
            this.donhang_dongia_khohang.Name = "donhang_dongia_khohang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_madh_donhang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_xacnhan_giohang);
            this.groupBox2.Controls.Add(this.cb_manv_donhang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_xoa_giohang);
            this.groupBox2.Controls.Add(this.lb_tongtien_giohang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cb_makh_donhang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView_giohang_in_donhang);
            this.groupBox2.Location = new System.Drawing.Point(29, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 290);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // btn_xacnhan_giohang
            // 
            this.btn_xacnhan_giohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_xacnhan_giohang.Location = new System.Drawing.Point(966, 217);
            this.btn_xacnhan_giohang.Name = "btn_xacnhan_giohang";
            this.btn_xacnhan_giohang.Size = new System.Drawing.Size(116, 49);
            this.btn_xacnhan_giohang.TabIndex = 46;
            this.btn_xacnhan_giohang.Text = "Xác nhận đơn hàng";
            this.btn_xacnhan_giohang.UseVisualStyleBackColor = true;
            this.btn_xacnhan_giohang.Click += new System.EventHandler(this.btn_xacnhan_giohang_Click);
            // 
            // cb_manv_donhang
            // 
            this.cb_manv_donhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_manv_donhang.FormattingEnabled = true;
            this.cb_manv_donhang.Location = new System.Drawing.Point(784, 146);
            this.cb_manv_donhang.Name = "cb_manv_donhang";
            this.cb_manv_donhang.Size = new System.Drawing.Size(149, 24);
            this.cb_manv_donhang.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(651, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mã nhân viên";
            // 
            // btn_xoa_giohang
            // 
            this.btn_xoa_giohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_xoa_giohang.Location = new System.Drawing.Point(966, 101);
            this.btn_xoa_giohang.Name = "btn_xoa_giohang";
            this.btn_xoa_giohang.Size = new System.Drawing.Size(116, 49);
            this.btn_xoa_giohang.TabIndex = 42;
            this.btn_xoa_giohang.Text = "Xóa khỏi giỏ hàng";
            this.btn_xoa_giohang.UseVisualStyleBackColor = true;
            this.btn_xoa_giohang.Click += new System.EventHandler(this.btn_xoa_giohang_Click);
            // 
            // lb_tongtien_giohang
            // 
            this.lb_tongtien_giohang.AutoSize = true;
            this.lb_tongtien_giohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_tongtien_giohang.Location = new System.Drawing.Point(829, 233);
            this.lb_tongtien_giohang.Name = "lb_tongtien_giohang";
            this.lb_tongtien_giohang.Size = new System.Drawing.Size(24, 17);
            this.lb_tongtien_giohang.TabIndex = 41;
            this.lb_tongtien_giohang.Text = "0đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(651, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tổng tiền:";
            // 
            // cb_makh_donhang
            // 
            this.cb_makh_donhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_makh_donhang.FormattingEnabled = true;
            this.cb_makh_donhang.Location = new System.Drawing.Point(784, 97);
            this.cb_makh_donhang.Name = "cb_makh_donhang";
            this.cb_makh_donhang.Size = new System.Drawing.Size(149, 24);
            this.cb_makh_donhang.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(651, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(470, 0, 500, 0);
            this.label1.Size = new System.Drawing.Size(1173, 41);
            this.label1.TabIndex = 37;
            this.label1.Text = "ĐƠN HÀNG";
            // 
            // tb_madh_donhang
            // 
            this.tb_madh_donhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_madh_donhang.Location = new System.Drawing.Point(784, 48);
            this.tb_madh_donhang.Name = "tb_madh_donhang";
            this.tb_madh_donhang.Size = new System.Drawing.Size(149, 23);
            this.tb_madh_donhang.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(651, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Mã đơn hàng";
            // 
            // Thanh_toán
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thanh_toán";
            this.Text = "Thanh_toán";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giohang_in_donhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_donhang_anhsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khohang_in_donhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_giohang_in_donhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_khohang_in_donhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_donhang_soluongdat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_donhang_them;
        private System.Windows.Forms.PictureBox picBox_donhang_anhsp;
        private System.Windows.Forms.Button btn_xacnhan_giohang;
        private System.Windows.Forms.ComboBox cb_manv_donhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_xoa_giohang;
        private System.Windows.Forms.Label lb_tongtien_giohang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_makh_donhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_masp_khohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_tensp_khohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_chitiet_khohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_soluongcon_khohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_dongia_khohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_tensp_giohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_masp_giohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_soluong_giohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_dongia_giohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang_tongtien_giohang;
        private System.Windows.Forms.TextBox tb_madh_donhang;
        private System.Windows.Forms.Label label5;
    }
}