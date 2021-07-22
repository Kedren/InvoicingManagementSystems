using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class UserBLL
    {
        private UserDAL us;
        public UserBLL()
        {
            us = new UserDAL();
        }
        public List<User> GetList()
        {
            return us.GetList();
        }
        public bool Insert(User o)
        {
            return us.Insert(o);
        }
        public bool Delete(User o)
        {
            return us.Delete(o);
        }
        public bool Update(User o)
        {
            return us.Update(o);
        }
        public User FindByID(string id)
        {
            return us.FindByID(id);
        }
        public bool User_Login(User o)
        {
            return us.User_Login(o);
        }
    }
}
