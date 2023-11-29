using A_DAL.DomainClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class TheLoaiRes : ITheLoai
    {
        public string? GetTheLoaiByID(string id)
        {

            List<String> theLoaiList = (from TL in dbConnection._dbDuAn.TheLoaiSaches
                                        join TLCT in dbConnection._dbDuAn.ChiTietTheLoais on TL.ViTriKeSach equals TLCT.ViTriKeSach
                                        where TLCT.BarCode == id
                                        select TL.TenTheLoai).ToList();

            return String.Join(", ", theLoaiList);
        }

        public List<TheLoaiSach> GetAllTheLoai()
        {
            return dbConnection._dbDuAn.TheLoaiSaches.ToList();
        }

        public bool Add(string barcode, string ViTri)
        {
            try
            {
                var tmp = new ChiTietTheLoai();
                tmp.ViTriKeSach = ViTri;
                tmp.BarCode = barcode;
                dbConnection._dbDuAn.ChiTietTheLoais.Add(tmp);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}
