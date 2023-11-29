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
    public class TacGiaRes : ITacGia
    {
        public string? GetTacGiaByID(string id)
        {

            List<String> tacGiaList = (from TG in dbConnection._dbDuAn.TacGiaSaches
                                       where TG.BarCodeSach == id
                                       select TG.Name).ToList();

            return String.Join(", ", tacGiaList);
        }


        public bool Add(string barcode, string TacGia)
        {
            String[] spearator = { ", ", ". ", "; " };
            Int32 count = 2;
            String[] tacGiaArray = TacGia.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (String s in tacGiaArray)
                {
                    var tmp = new TacGiaSach();
                    tmp.BarCodeSach = barcode;
                    tmp.Name = s;
                    dbConnection._dbDuAn.TacGiaSaches.Add(tmp);
                }
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
