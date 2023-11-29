using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;
using System.Diagnostics;

namespace A_DAL.Repositories
{
    public class SachRes : iSachRes
    {

        public List<Sach?> getAll()
        {
            return dbConnection._dbDuAn.Saches.ToList();
        }

        public int getCountById(string Id)
        {
            return dbConnection._dbDuAn.SachChiTiets.Where(sct => sct.BarCodeSach.Equals(Id)).Count();
        }

        public bool Add(Sach sach, string TacGia, string Vitri)
        {
            ITacGia itg = new TacGiaRes();
            ITheLoai itl = new TheLoaiRes();
            try
            {
                dbConnection._dbDuAn.Saches.Add(sach);
                dbConnection._dbDuAn.SaveChanges();
                //if (!itg.Add(sach.BarCodeSach, TacGia))
                //return false;
                if (!itl.Add(sach.BarCodeSach, Vitri))
                    return false;
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
    }
}
