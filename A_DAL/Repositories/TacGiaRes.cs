using A_DAL.DomainClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class TacGiaRes : ITacGia
    {
        public string? GetTacGiaByID(string id)
        {

            List<String> tacGiaList = (from TG in dbConnection._dbDuAn.TacGia
                                       join TGS in dbConnection._dbDuAn.TacGiaSaches on TG.IdTacGia equals TGS.IdTacGia
                                       where TGS.BarCodeSach == id
                                       select TG.HoTen).ToList();

            return String.Join(", ", tacGiaList);
        }
    }
}
