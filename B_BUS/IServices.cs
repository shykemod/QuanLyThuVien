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

        public bool? Login(string username, string password); //Đăng nhập
        public List<Sach?> GetAllSach(); //Lấy list sách
        public int getCount(string Id);
        public List<SachChiTiet?> GetAllSachCT(string Id); //Lấy list sách chi tiết
        public string? GetTacGiaByID(string id); //Lấy Tác giả sách
        public string? GetTheLoaiByID(string id); //Lấy thể loại sách


    }
}
