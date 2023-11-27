
using A_DAL.IRepositories;
using A_DAL.DomainClass;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace B_BUS
{
    public class Services : IServices
    {
        public static IUserRes UserRes = new UserRes(); //Khởi tạo biến tài khoản repos
        public static iSachRes SachRes = new SachRes(); //Khởi tạo biến Sách repos
        public static ISachCTRes SachCTRes = new SachCTRes(); //Khởi tạo biến Sách Chi tiết repos
        public static ITacGia TacGiaRes = new TacGiaRes(); //Khởi tạo biến tác giả repos
        public static ITheLoai TheLoaiRes = new TheLoaiRes(); //Khởi tạo biến thể loại repos


        public bool? Login(string username, string password) => UserRes.Login(username, password);
        public List<Sach?> GetAllSach() => SachRes.getAll(); //Lấy danh sách sách
        public int getCount(string Id) => SachRes.getCount(Id); //Lấy số lượng sách
        public List<SachChiTiet?> GetAllSachCT(string Id) => SachCTRes.getAll(Id); //Lấy danh sách sách

        public string? GetTacGiaByID(string id) => TacGiaRes.GetTacGiaByID(id); //Lấy chuỗi tên tác giả của sách theo mã sách
        public string? GetTheLoaiByID(string id) => TheLoaiRes.GetTheLoaiByID(id); //Lấy chuỗi thể loại của sách theo mã sách
    }

}
