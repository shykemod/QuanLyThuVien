using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class UserRes : IUserRes
    {
        public bool? Login(string username, string password)
        {
            return dbConnection._dbDuAn.TaiKhoans.Where(tk => tk.UserName.Equals(username) && tk.PassWord.Equals(password)).Select(tk => tk.Role).FirstOrDefault();
        }
    }
}
