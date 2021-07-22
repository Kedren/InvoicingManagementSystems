using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class ProductBLL
    {
        private ProductDAL pr;
        public ProductBLL()
        {
            pr = new ProductDAL();
        }
        public List<Product> GetList()
        {
            return pr.GetList();
        }
        public bool Insert(Product o)
        {
            return pr.Insert(o);
        }
        public bool Delete(Product o)
        {
            return pr.Delete(o);
        }
        public bool Update(Product o)
        {
            return pr.Update(o);
        }
        public Product FindByID(string id)
        {
            return pr.FindByID(id);
        }

        public List<Product> FindProductBySpellingCode(string spellinhCode)
        {
            return pr.FindProductBySpellingCode(spellinhCode);
        }
        public List<Product> GetProductByProductIDAndProductName(Product o)
        {
            return pr.GetProductByProductIDAndProductName(o);
        }
    }
}
