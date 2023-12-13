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
    public partial class Thanh_toán : Form
    {
        public Thanh_toán()
        {
            InitializeComponent();
            LoadDataXML();
            // data binding
            dataGridView_khohang_in_donhang.SelectionChanged += DataGridView_sp_kho_SelectionChanged;
        }

        // Load data to gridview Kho hang
        private void LoadDataXML()
        {
            // Load XML file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\DienThoais.xml");

            // DataGridView
            foreach (XmlNode node in xmlDoc.SelectNodes("//DienThoai"))
            {
                string maDT = node.SelectSingleNode("MaDT").InnerText;
                string tenDT = node.SelectSingleNode("TenDT").InnerText;
                string moTa = node.SelectSingleNode("MoTa").InnerText;
                decimal gia = Convert.ToDecimal(node.SelectSingleNode("Gia").InnerText);
                int soLuong = Convert.ToInt32(node.SelectSingleNode("SoLuong").InnerText);

                int rowIndex = dataGridView_khohang_in_donhang.Rows.Add();
                dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_masp_khohang"].Value = maDT;
                dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_tensp_khohang"].Value = tenDT;
                dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_chitiet_khohang"].Value = moTa;
                dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_dongia_khohang"].Value = gia;
                dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_soluongcon_khohang"].Value = soLuong;
            }

            // combobox
            LoadDataToComboBox();
        }

        // load data trong combobox Don hang
        private void LoadDataToComboBox()
        {
            // Load XML file
            XDocument xdocKH = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\KhachHangs.xml");
            XDocument xdocNV = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\NhanViens.xml");

            // Get all MaKH elements
            var maKHList = xdocKH.Descendants("MaKH").Select(maKH => maKH.Value).ToList();
            var maNVList = xdocNV.Descendants("MaNV").Select(maNV => maNV.Value).ToList();

            // Bind the list to the ComboBox
            cb_makh_donhang.DataSource = maKHList;
            cb_manv_donhang.DataSource = maNVList;

        }
        
        // load image when click item in gridview Kho hang
        private void DataGridView_sp_kho_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is any selected row
            if (dataGridView_khohang_in_donhang.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_khohang_in_donhang.SelectedRows[0];

                // textbox
                string ma_dien_thoai = selectedRow.Cells["donhang_masp_khohang"].Value.ToString();

                // Update the corresponding <DienThoai> element in the XML file
                XDocument xdoc = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\DienThoais.xml");

                // Find the <DienThoai> element with the matching MaDT
                XElement dienThoaiElement = xdoc.Descendants("DienThoai")
                    .FirstOrDefault(dt => dt.Element("MaDT").Value == ma_dien_thoai);

                if (dienThoaiElement != null)
                {
                    string imgFileName = dienThoaiElement.Element("Anh").Value;

                    // Construct the full path of the image file
                    string fullPath = Path.Combine(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\images\", imgFileName);

                    // Check if the file exists before loading the image
                    if (File.Exists(fullPath))
                    {
                        Image image = Image.FromFile(fullPath);

                        picBox_donhang_anhsp.Image = image;
                    }
                    else
                    {
                        // Handle the case where the image file is not found
                        MessageBox.Show($"Image file not found: {fullPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Insert Don hang to gridview Gio hang
        private void btn_donhang_them_Click(object sender, EventArgs e)
        {
            // Check if there is any selected row
            if (dataGridView_khohang_in_donhang.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_khohang_in_donhang.SelectedRows[0];

                // get data from gridview Kho hang
                string masp = selectedRow.Cells["donhang_masp_khohang"].Value.ToString();
                string tensp = selectedRow.Cells["donhang_tensp_khohang"].Value.ToString();
                decimal dongia = decimal.Parse(selectedRow.Cells["donhang_dongia_khohang"].Value.ToString());
                int soluongcon = int.Parse(selectedRow.Cells["donhang_soluongcon_khohang"].Value.ToString());
                int soluongdat = int.Parse(tb_donhang_soluongdat.Text);
                decimal tongtien = soluongdat * dongia;

                // insert data to gridview Gio hang
                dataGridView_giohang_in_donhang.Rows.Add(tensp, masp, soluongdat, dongia, tongtien);

                // 1: mua san pham => soluong-- | 2: tra san pham => soluong++
                UpdateSoLuongConXML(1, masp, soluongdat);

                // tinh tong tien don hang, 1: mua hang -> tongtien++, 2: tra hang -> tongtien--
                TongTienDonHang(1, tongtien);

                // update soluong datagridview Kho hang
                int index = selectedRow.Index;

                dataGridView_khohang_in_donhang.Rows[index].Cells["donhang_soluongcon_khohang"].Value = soluongcon - soluongdat;

                // Refresh the DataGridView to reflect the changes
                dataGridView_khohang_in_donhang.Refresh();

                tb_donhang_soluongdat.Text = String.Empty;      
            }
        }
        
        // ting tong tien trong don hang
        decimal TONGTIEN = 0;
        private void TongTienDonHang(int check, decimal amount)
        {
            if (check == 1)
            {
                TONGTIEN += amount;
                lb_tongtien_giohang.Text = TONGTIEN.ToString() + " dong";
            }
            else
            {
                TONGTIEN -= amount;
                lb_tongtien_giohang.Text = TONGTIEN.ToString() + " dong";
            }
        }

        // update so luong trong XML khi mua, tra hang
        private void UpdateSoLuongConXML(int check, string msp, int amount)
        {
            // Update the corresponding <DienThoai> element in the XML file
            XDocument xdoc = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\DienThoais.xml");

            // Find the <DienThoai> element with the matching MaDT
            XElement dienThoaiElement = xdoc.Descendants("DienThoai")
                .FirstOrDefault(dt => dt.Element("MaDT").Value == msp);

            // get soluong con from xml
            int soluongcon = int.Parse(dienThoaiElement.Element("SoLuong").Value);

            // update soluong
            if (check == 1) 
                soluongcon -= amount;
            else
                soluongcon += amount;

            // Update the values in the XML file
            dienThoaiElement?.SetElementValue("SoLuong", soluongcon);

            // Save the changes to the XML file
            xdoc.Save(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\DienThoais.xml");
        }

        // xoa san pham trong gio hang
        private void btn_xoa_giohang_Click(object sender, EventArgs e)
        {

            // Check if there is any selected row
            if (dataGridView_giohang_in_donhang.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_giohang_in_donhang.SelectedRows[0];

                // get data from gridview gio hang
                string masp = selectedRow.Cells["donhang_masp_giohang"].Value.ToString();
                int soluongtra = int.Parse(selectedRow.Cells["donhang_soluong_giohang"].Value.ToString());
                decimal tongtien = decimal.Parse(selectedRow.Cells["donhang_tongtien_giohang"].Value.ToString());

                // 1: mua san pham => soluong-- | 2: tra san pham => soluong++
                UpdateSoLuongConXML(2, masp, soluongtra);

                // tinh tong tien don hang, 1: mua hang -> tongtien++, 2: tra hang -> tongtien--
                TongTienDonHang(2, tongtien);

                // update soluong datagridview Kho hang
                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView_khohang_in_donhang.Rows)
                {
                    if (row.Cells["donhang_masp_khohang"].Value.ToString() == masp)
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

                // If the rowIndex is found, update the 'donhang_soluongcon_khohang' column
                if (rowIndex != -1)
                {
                    int soluongcon = int.Parse(dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_soluongcon_khohang"].Value.ToString());
                    dataGridView_khohang_in_donhang.Rows[rowIndex].Cells["donhang_soluongcon_khohang"].Value = soluongcon + soluongtra;
                }

                // Refresh the DataGridView to reflect the changes
                dataGridView_khohang_in_donhang.Refresh();

                // Remove the row from dataGridView gio hang
                dataGridView_giohang_in_donhang.Rows.Remove(selectedRow);
            }
        }

        // xac nhan mua hang
        private void btn_xacnhan_giohang_Click(object sender, EventArgs e)
        {
            string madh = tb_madh_donhang.Text;
            string makh = cb_makh_donhang.Text;
            string manv = cb_manv_donhang.Text;
            DateTime today = DateTime.Now;
            string ngaydh = today.ToString("yyyy-MM-dd");

            // Insert to DonHangs.xml
            XElement newDonHang = new XElement("DonHang",
                new XElement("MaDH", madh),
                new XElement("NgayDH", ngaydh),
                new XElement("MaKH", makh),
                new XElement("MaNV", manv)
            );

            XDocument xdocDH = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\DonHangs.xml");
            xdocDH.Element("DonHangs").Add(newDonHang);
            xdocDH.Save(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\DonHangs.xml");

            // Insert to ChiTietDonHangs.xml
            XDocument xdocCTDH = XDocument.Load(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\ChiTietDonHangs.xml");
            foreach (DataGridViewRow row in dataGridView_giohang_in_donhang.Rows)
            {
                if (!row.IsNewRow)
                { 
                    // Check if the cell value is not null before accessing it
                    if (row.Cells["donhang_masp_giohang"].Value != null && row.Cells["donhang_soluong_giohang"].Value != null)
                    {
                        // Get data from DataGridView
                        string maDT = row.Cells["donhang_masp_giohang"].Value.ToString();

                        // Check if the cell value is not null before parsing it
                        if (int.TryParse(row.Cells["donhang_soluong_giohang"].Value.ToString(), out int soLuong))
                        {
                            // Add a new ChiTietDonHang element
                            XElement chiTietDonHangElement = new XElement("ChiTietDonHang",
                                new XElement("MaDH", madh),
                                new XElement("MaDT", maDT),
                                new XElement("SoLuong", soLuong));

                            // Add the new ChiTietDonHang element to the XML file
                            xdocCTDH.Root.Add(chiTietDonHangElement);
                        }
                        else
                        {
                            // Handle the case where parsing to integer fails
                            MessageBox.Show("Invalid 'SoLuong' value in DataGridView.");
                        }
                    }
                    else
                    {
                        // Handle the case where the cell value is null
                        MessageBox.Show("Null value in DataGridView cell.");
                    }
                }
            }

            xdocCTDH.Save(@"D:\UTE_CODE\XML\CuoiKyXML_BanDienThoai\BT_CK_CNXML\XML\ChiTietDonHangs.xml");

            // clear textbox and datagridview
            tb_madh_donhang.Text = String.Empty;
            lb_tongtien_giohang.Text = String.Empty;
            dataGridView_giohang_in_donhang.Rows.Clear();
        }
    }
}
