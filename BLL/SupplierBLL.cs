using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class SupplierBLL
    {
        private SupplierDAL su;
        public SupplierBLL()
        {
            su = new SupplierDAL();
        }
        public List<Supplier> GetList()
        {
            return su.GetList();
        }
        public bool Insert(Supplier o)
        {
            return su.Insert(o);
        }
        public bool Delete(Supplier o)
        {
            return su.Delete(o);
        }
        public bool Update(Supplier o)
        {
            return su.Update(o);
        }
        public Supplier FindByID(string id)
        {
            return su.FindByID(id);
        }
        public List<Supplier> GetSupplierBySupplierIDAndSupplierName(Supplier o)
        {
            return su.GetSupplierBySupplierIDAndSupplierName(o);
        }
    }
}
