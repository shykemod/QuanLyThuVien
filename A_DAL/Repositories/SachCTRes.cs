using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class SachCTRes : ISachCTRes
    {

        public List<SachChiTiet?> getAll(string Id)
        {
            return dbConnection._dbDuAn.SachChiTiets.Where(sct => sct.BarCodeSach == Id).ToList();
        }
    }
}
