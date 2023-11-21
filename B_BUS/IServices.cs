using A_DAL.Context;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;


namespace B_BUS
{
    public interface IServices
    {
        public List<Sach?> GetAllSach();
        public List<SachChiTiet?> GetAllSachCT(string Id);
        public string? GetTacGiaByID(string id);
        public string? GetTheLoaiByID(string id);


    }
}
