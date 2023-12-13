using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace test1
{
    public partial class Quản_lý_kho_hàng : Form
    {
        public Quản_lý_kho_hàng()
        {
            InitializeComponent();

            LoadDataFromXML();

            // data binding
            dataGridView_sp_kho.SelectionChanged += DataGridView_sp_kho_SelectionChanged;
        }

        private void LoadDataFromXML()
        {
            // Load XML file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("DienThoais.xml");

            // Iterate through XML nodes and populate DataGridView
            foreach (XmlNode node in xmlDoc.SelectNodes("//DienThoai"))
            {
                string maDT = node.SelectSingleNode("MaDT").InnerText;
                string tenDT = node.SelectSingleNode("TenDT").InnerText;
                string moTa = node.SelectSingleNode("MoTa").InnerText;
                decimal gia = Convert.ToDecimal(node.SelectSingleNode("Gia").InnerText);
                int soLuong = Convert.ToInt32(node.SelectSingleNode("SoLuong").InnerText);
                string anhFileName = node.SelectSingleNode("Anh").InnerText;

                // Construct the full path of the image file
                string fullPath = Path.Combine(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\images\", anhFileName);
                //string fullPath = @"D:\UTE_CODE\XML\CUOIKY_QLBanDienThoai\BT_CK_CNXML\BT_CK_CNXML\images\hinh6.png";

                // Check if the file exists before loading the image
                if (File.Exists(fullPath))
                {
                    Image image = Image.FromFile(fullPath);

                    int rowIndex = dataGridView_sp_kho.Rows.Add();
                    dataGridView_sp_kho.Rows[rowIndex].Cells["kho_masp"].Value = maDT;
                    dataGridView_sp_kho.Rows[rowIndex].Cells["kho_tensp"].Value = tenDT;
                    dataGridView_sp_kho.Rows[rowIndex].Cells["kho_mota"].Value = moTa;
                    dataGridView_sp_kho.Rows[rowIndex].Cells["kho_dongia"].Value = gia;
                    dataGridView_sp_kho.Rows[rowIndex].Cells["kho_sluong"].Value = soLuong;
                    dataGridView_sp_kho.Rows[rowIndex].Cells["kho_anhsp"].Value = image;
                }
                else
                {
                    // Handle the case where the image file is not found
                    MessageBox.Show($"Image file not found: {fullPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DataGridView_sp_kho_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is any selected row
            if (dataGridView_sp_kho.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_sp_kho.SelectedRows[0];

                // textbox
                tb_ma_sp_kho.Text = selectedRow.Cells["kho_masp"].Value.ToString();
                tb_ten_sp_kho.Text = selectedRow.Cells["kho_tensp"].Value.ToString();
                tb_mota_sp_kho.Text = selectedRow.Cells["kho_mota"].Value.ToString();
                tb_soluong_sp_kho.Text = selectedRow.Cells["kho_sluong"].Value.ToString();
                tb_dongia_sp_kho.Text = selectedRow.Cells["kho_dongia"].Value.ToString();

                // picture box
                if (selectedRow.Cells["kho_anhsp"].Value != null)
                {
                    DataGridViewImageCell imageCell = (DataGridViewImageCell)selectedRow.Cells["kho_anhsp"];
                    Image img = (Image)imageCell.Value;
                   
                    picBox_anh_sp_kho.Image = img;

                }
                else
                {
                    // Clear picture box if there is no image
                    picBox_anh_sp_kho.Image = null;
                }
            }
        }

        private void btn_reset_sp_kho_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            tb_ma_sp_kho.Text = string.Empty;
            tb_ten_sp_kho.Text = string.Empty;
            tb_mota_sp_kho.Text = string.Empty;
            tb_soluong_sp_kho.Text = string.Empty;
            tb_dongia_sp_kho.Text = string.Empty;
            picBox_anh_sp_kho.Image = null;
        }

        private void btn_add_img_kho_Click(object sender, EventArgs e)
        {
            // Open a file dialog to choose an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the chosen image to the PictureBox
                picBox_anh_sp_kho.Image = Image.FromFile(openFileDialog.FileName);

                // Store the file name in the Tag property
                picBox_anh_sp_kho.Tag = openFileDialog.FileName;
            }
        }

        private void btn_them_sp_kho_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string maSp = tb_ma_sp_kho.Text;
            string tenSp = tb_ten_sp_kho.Text;
            string moTa = tb_mota_sp_kho.Text;
            int soLuong = int.Parse(tb_soluong_sp_kho.Text);
            decimal donGia = decimal.Parse(tb_dongia_sp_kho.Text);

            // Get image data from PictureBox
            Image img = picBox_anh_sp_kho.Image;

            // Add a new row to dataGridView_sp_kho
            dataGridView_sp_kho.Rows.Add(maSp, tenSp, moTa, soLuong, donGia, img);

            // Get the file name from the Tag property
            string fileName = picBox_anh_sp_kho.Tag?.ToString();

            // Insert a new <DienThoai> element into the XML file
            XElement newDienThoai = new XElement("DienThoai",
                new XElement("MaDT", maSp),
                new XElement("TenDT", tenSp),
                new XElement("MoTa", moTa),
                new XElement("Gia", donGia),
                new XElement("SoLuong", soLuong),
                new XElement("Anh", fileName)
            );

            XDocument xdoc = XDocument.Load("DienThoais.xml");
            xdoc.Element("DienThoais").Add(newDienThoai);
            xdoc.Save("DienThoais.xml");

            // Clear data in textboxes and picture box
            ClearData();
        }

        private void btn_sua_sp_kho_Click(object sender, EventArgs e)
        {
            // Check if there is any selected row
            if (dataGridView_sp_kho.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_sp_kho.SelectedRows[0];

                // Get the index of the selected row
                int rowIndex = selectedRow.Index;

                // Get the file name from the Tag property
                string fileName = picBox_anh_sp_kho.Tag?.ToString();

                // Get data from textboxes
                string maSp = tb_ma_sp_kho.Text;
                string tenSp = tb_ten_sp_kho.Text;
                string moTa = tb_mota_sp_kho.Text;
                int soLuong = int.Parse(tb_soluong_sp_kho.Text);
                decimal donGia = decimal.Parse(tb_dongia_sp_kho.Text);

                // Get image data from PictureBox
                Image img = picBox_anh_sp_kho.Image;

                // Update the row in dataGridView_sp_kho
                dataGridView_sp_kho.Rows[rowIndex].SetValues(maSp, tenSp, moTa, soLuong, donGia, img);

                // Update the corresponding <DienThoai> element in the XML file
                XDocument xdoc = XDocument.Load("DienThoais.xml");

                // Find the <DienThoai> element with the matching MaDT
                XElement dienThoaiElement = xdoc.Descendants("DienThoai")
                    .FirstOrDefault(dt => dt.Element("MaDT").Value == maSp);

                // Update the values in the XML file
                dienThoaiElement?.SetElementValue("TenDT", tenSp);
                dienThoaiElement?.SetElementValue("MoTa", moTa);
                dienThoaiElement?.SetElementValue("Gia", donGia);
                dienThoaiElement?.SetElementValue("SoLuong", soLuong);
                dienThoaiElement?.SetElementValue("Anh", fileName);

                // Save the changes to the XML file
                xdoc.Save("DienThoais.xml");

                // Clear data in textboxes and picture box
                ClearData();
            }
        }

        private void btn_xoa_sp_kho_Click(object sender, EventArgs e)
        {
            // Check if there is any selected row
            if (dataGridView_sp_kho.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_sp_kho.SelectedRows[0];

                // Get the MaDT
                string maSp = selectedRow.Cells["kho_masp"].Value.ToString();

                // Remove the row from dataGridView_sp_kho
                dataGridView_sp_kho.Rows.Remove(selectedRow);

                // Remove the corresponding <DienThoai> element from the XML file
                XDocument xdoc = XDocument.Load("DienThoais.xml");

                // Find the <DienThoai> element with the matching MaDT
                XElement dienThoaiElement = xdoc.Descendants("DienThoai")
                    .FirstOrDefault(dt => dt.Element("MaDT").Value == maSp);

                // Remove the element from the XML file
                dienThoaiElement?.Remove();

                // Save the changes to the XML file
                xdoc.Save("DienThoais.xml");

                // Clear data in textboxes and picture box
                ClearData();
            }
        }
    }
}

