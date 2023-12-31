﻿
using B_BUS;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.DomainClass;
using System.Globalization;
using C_PRL.qlsach;

namespace C_PRL
{
    public partial class FormQLSach : Form
    {
        List<Sach?> sachList;

        public FormQLSach()
        {
            InitializeComponent();
        }


        private void QuanLySach_Load(object sender, EventArgs e)
        {
            ShowData("", 0);
            if (!LoginForm.Role)
            {
                btnThem.Hide();
            }
        }


        void ConfigData()
        {
            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                dataGridView1.Rows.Add(
                i.ToString(),
                sach.BarCodeSach,
                sach.TenSach,
                sach.GiaTien,
                sach.NamXuatBan?.ToString("dd/MM/yyyy"),
                svc.services.GetTacGiaByID(sach.BarCodeSach),
                svc.services.GetTheLoaiByID(sach.BarCodeSach),
                svc.services.getCountById(sach.BarCodeSach)
                );
            }
        }

        void ShowData(string searchText, int Type)
        {
            sachList = svc.services.GetAllSach();
            ConfigData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Form ql = new QuanLySachChiTiet(sachList[e.RowIndex].BarCodeSach);
                ql.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form AddTTSach = new ThemTTSach();
            AddTTSach.ShowDialog();
        }
    }
}
