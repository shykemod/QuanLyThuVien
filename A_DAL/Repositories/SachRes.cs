using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;

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
    }
}
