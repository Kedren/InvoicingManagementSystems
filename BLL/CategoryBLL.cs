using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class CategoryBLL
    {
        private CategoryDAL ca;
        public CategoryBLL()
        {
            ca = new CategoryDAL();
        }
        public List<Category> GetList()
        {
            return ca.GetList();
        }
        public bool Insert(Category o)
        {
            return ca.Insert(o);
        }
        public bool Delete(Category o)
        {
            return ca.Delete(o);
        }
        public bool Update(Category o)
        {
            return ca.Update(o);
        }
        public Category FindByID(string id)
        {
            return ca.FindByID(id);
        }
        public List<Category> GetCategoryByCategoryIDAndCategyName(Category o)
        {
            return ca.GetCategoryByCategoryIDAndCategyName(o);
        }
    }
}
