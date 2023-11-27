using A_DAL.DomainClass;
using B_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace C_PRL.qlsach
{
    public partial class ThemTTSach : Form
    {
        List<TheLoaiSach> theLoaiSachList;
        public ThemTTSach()
        {
            InitializeComponent();

            BarcodeScanner barcodeScanner = new BarcodeScanner(tbBarcode);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void ThemTTSach_Load(object sender, EventArgs e)
        {
            theLoaiSachList = svc.services.GetAllTheLoai();
            foreach (var item in theLoaiSachList)
            {
                comboBox1.Items.Add(item.ViTriKeSach + " -- " + item.TenTheLoai);
            }
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            tbBarcode.Text = e.Barcode;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBarcode.Text, "[^0-9]"))
            {
                tbBarcode.Text = tbBarcode.Text.Remove(tbBarcode.Text.Length - 1);
            }
        }
    }
}
