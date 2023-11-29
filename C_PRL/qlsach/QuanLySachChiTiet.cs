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

namespace C_PRL
{
    public partial class QuanLySachChiTiet : Form
    {
        List<SachChiTiet?> sachCTList;
        string IdSach;

        public QuanLySachChiTiet(string id)
        {
            InitializeComponent();
            IdSach = id;
        }


        private void QuanLySachChiTiet_Load(object sender, EventArgs e)
        {
            ShowData("", 0);
        }

        void ConfigData()
        {
            for (int i = 1; i <= sachCTList.Count; i++)
            {
                var sachCT = sachCTList[i - 1];
                dataGridView1.Rows.Add(
                i.ToString(),
                sachCT.BarCodeMaSach,
                sachCT.TinhTrangSach,
                sachCT.LanTaiBan,
                sachCT.NamTaiBan,
                sachCT.KichCo,
                sachCT.DiemUyTinMin
                );
            }
        }

        void ShowData(string searchText, int Type)
        {
            sachCTList = svc.services.GetAllSachCT(IdSach);
            ConfigData();
        }

    }
}
