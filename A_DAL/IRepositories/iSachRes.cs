using A_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;

namespace A_DAL.IRepositories
{
    public interface iSachRes
    {
        List<Sach?> getAll();
    }
}
