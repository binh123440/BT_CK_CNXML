
namespace test1
{
    partial class Cập_nhật_sao_lưu
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
            this.btn_XML2SQL = new System.Windows.Forms.Button();
            this.btn_SQL2XML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(147, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT - SAO LƯU DỮ LIỆU";
            // 
            // btn_XML2SQL
            // 
            this.btn_XML2SQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XML2SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_XML2SQL.Location = new System.Drawing.Point(277, 169);
            this.btn_XML2SQL.Name = "btn_XML2SQL";
            this.btn_XML2SQL.Size = new System.Drawing.Size(235, 55);
            this.btn_XML2SQL.TabIndex = 1;
            this.btn_XML2SQL.Text = "XML to SQL";
            this.btn_XML2SQL.UseVisualStyleBackColor = false;
            this.btn_XML2SQL.Click += new System.EventHandler(this.btn_XML2SQL_Click);
            // 
            // btn_SQL2XML
            // 
            this.btn_SQL2XML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SQL2XML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_SQL2XML.Location = new System.Drawing.Point(277, 265);
            this.btn_SQL2XML.Name = "btn_SQL2XML";
            this.btn_SQL2XML.Size = new System.Drawing.Size(235, 55);
            this.btn_SQL2XML.TabIndex = 2;
            this.btn_SQL2XML.Text = "SQL to XML";
            this.btn_SQL2XML.UseVisualStyleBackColor = false;
            this.btn_SQL2XML.Click += new System.EventHandler(this.btn_SQL2XML_Click);
            // 
            // Cập_nhật_sao_lưu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SQL2XML);
            this.Controls.Add(this.btn_XML2SQL);
            this.Controls.Add(this.label1);
            this.Name = "Cập_nhật_sao_lưu";
            this.Text = "Cập_nhật_sao_lưu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XML2SQL;
        private System.Windows.Forms.Button btn_SQL2XML;
    }
}