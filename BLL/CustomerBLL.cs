using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class CustomerBLL
    {
        private CustomerDAL cu;
        public CustomerBLL()
        {
            cu = new CustomerDAL();
        }
        public List<Customer> GetList()
        {
            return cu.GetList();
        }
        public bool Insert(Customer o)
        {
            return cu.Insert(o);
        }
        public bool Delete(Customer o)
        {
            return cu.Delete(o);
        }
        public bool Update(Customer o)
        {
            return cu.Update(o);
        }
        public Customer FindByID(string id)
        {
            return cu.FindByID(id);
        }
        public List<Customer> GetCustomerByCustomerIDAndCustomerName(Customer o)
        {
            return cu.GetCustomerByCustomerIDAndCustomerName(o);
        }
    }
}
