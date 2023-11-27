using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ITheLoai
    {
        public string? GetTheLoaiByID(string id);
        public List<TheLoaiSach> GetAllTheLoai();
    }
}
