using A_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Query;

namespace A_DAL.IRepositories
{
    public interface iSachRes
    {
        List<Sach?> getAll();
        int getCountById(string Id);
        public bool Add(Sach sach, string TacGia, string Vitri);
    }
}
