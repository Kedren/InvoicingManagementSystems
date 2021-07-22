using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.Model;
using LuQiJing.DAL;

namespace LuQiJing.BLL
{
    public class EmployeeBLL
    {
        private EmployeeDAL em;
        public EmployeeBLL()
        {
            em = new EmployeeDAL();
        }
        public List<Employee> GetList()
        {
            return em.GetList();
        }
        public bool Insert(Employee o)
        {
            return em.Insert(o);
        }
        public bool Delete(Employee o)
        {
            return em.Delete(o);
        }
        public bool Update(Employee o)
        {
            return em.Update(o);
        }
        public Employee FindByID(string id)
        {
            return em.FindByID(id);
        }
        public List<Employee> GetEmployeeByEmployeeIDAndEmployeeName(Employee o)
        {
            return em.GetEmployeeByEmployeeIDAndEmployeeName(o);
        }
    }
}
