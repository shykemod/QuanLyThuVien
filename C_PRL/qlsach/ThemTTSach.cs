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

namespace C_PRL.qlsach
{
    public partial class ThemTTSach : Form
    {
        List<TheLoaiSach> theLoaiSachList;
        public ThemTTSach()
        {
            InitializeComponent();
        }

        private void ThemTTSach_Load(object sender, EventArgs e)
        {
            theLoaiSachList = svc.services.GetAllTheLoai();
            foreach (var item in theLoaiSachList)
            {
                cbbViTri.Items.Add(item.ViTriKeSach + " -- " + item.TenTheLoai);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Text.Length != 13)
            {
                MessageBox.Show("Mã barcode không hợp lệ, Vui Lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbBarcode.Focus(); return;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbName.Focus(); return;
            }
            decimal CheckGia;
            if (tbGia.Text == "" || !Decimal.TryParse(tbGia.Text, out CheckGia))
            {
                MessageBox.Show("Vui lòng nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbGia.Focus(); return;
            }

            if (tbTacgGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbTacgGia.Focus(); return;
            }
            if (cbbViTri.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbbViTri.Focus(); return;
            }
            var tmp = new Sach();
            tmp.BarCodeSach = tbBarcode.Text;
            tmp.TenSach = tbName.Text;
            tmp.GiaTien = Convert.ToDecimal(tbGia.Text);
            tmp.NamXuatBan = tbNXB.Value;

            if (svc.services.Add_Sach(tmp, tbTacgGia.Text, theLoaiSachList[cbbViTri.SelectedIndex].ViTriKeSach))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;

            }
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
