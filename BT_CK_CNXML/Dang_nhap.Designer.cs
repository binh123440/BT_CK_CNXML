﻿
namespace test1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTENDANGNHAP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMATKHAU = new System.Windows.Forms.TextBox();
            this.btDANGNHAP = new System.Windows.Forms.Button();
            this.lblDANGKY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(198, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // tbTENDANGNHAP
            // 
            this.tbTENDANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbTENDANGNHAP.Location = new System.Drawing.Point(311, 132);
            this.tbTENDANGNHAP.Name = "tbTENDANGNHAP";
            this.tbTENDANGNHAP.Size = new System.Drawing.Size(134, 30);
            this.tbTENDANGNHAP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(160, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(160, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // tbMATKHAU
            // 
            this.tbMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbMATKHAU.Location = new System.Drawing.Point(311, 186);
            this.tbMATKHAU.Name = "tbMATKHAU";
            this.tbMATKHAU.Size = new System.Drawing.Size(134, 30);
            this.tbMATKHAU.TabIndex = 3;
            // 
            // btDANGNHAP
            // 
            this.btDANGNHAP.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btDANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btDANGNHAP.Location = new System.Drawing.Point(238, 281);
            this.btDANGNHAP.Name = "btDANGNHAP";
            this.btDANGNHAP.Size = new System.Drawing.Size(149, 42);
            this.btDANGNHAP.TabIndex = 5;
            this.btDANGNHAP.Text = "ĐĂNG NHẬP";
            this.btDANGNHAP.UseVisualStyleBackColor = false;
            this.btDANGNHAP.Click += new System.EventHandler(this.btDANGNHAP_Click);
            // 
            // lblDANGKY
            // 
            this.lblDANGKY.AutoSize = true;
            this.lblDANGKY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDANGKY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDANGKY.Location = new System.Drawing.Point(360, 376);
            this.lblDANGKY.Name = "lblDANGKY";
            this.lblDANGKY.Size = new System.Drawing.Size(99, 17);
            this.lblDANGKY.TabIndex = 6;
            this.lblDANGKY.Text = "Đăng ký ở đây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(154, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chưa có tài khoản nhân viên ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDANGKY);
            this.Controls.Add(this.btDANGNHAP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMATKHAU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTENDANGNHAP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTENDANGNHAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMATKHAU;
        private System.Windows.Forms.Button btDANGNHAP;
        private System.Windows.Forms.Label lblDANGKY;
        private System.Windows.Forms.Label label5;
    }
}

