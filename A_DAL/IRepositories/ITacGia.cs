using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ITacGia
    {
        public string? GetTacGiaByID(string id);
        public bool Add(string barcode, string TacGia);
    }

}
