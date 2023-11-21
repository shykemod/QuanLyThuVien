using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
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
                                        join TLCT in dbConnection._dbDuAn.ChiTietTheLoais on TL.IdTheLoai equals TLCT.IdTheLoai
                                        where TLCT.BarCode == id
                                        select TL.TenTheLoai).ToList();

            return String.Join(", ", theLoaiList);
        }
    }
}
