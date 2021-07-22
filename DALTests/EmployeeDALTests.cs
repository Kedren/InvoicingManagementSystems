using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.EnterpriseServices;
using System.Data;
using LuQiJing.Model;

namespace LuQiJing.DAL.Tests
{
    [Transaction(TransactionOption.Required)]
    [TestClass()]
    public class EmployeeDALTests : ServicedComponent
    {
        [TestCleanup]
        public void TransactionOptionTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }
        EmployeeDAL emDAL;
        Employee em;
        public EmployeeDALTests()
        {
            emDAL = new EmployeeDAL();

        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Employee> list = new List<Employee>();
            list = emDAL.GetList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("001", list[0].EmployeeID.Trim());
            Assert.AreEqual("啊三", list[0].EmployeeName.Trim());
        }

        [TestMethod()]
        public void InsertTest()
        {
            em = new Employee("003", "啊三", 1, Convert.ToDateTime("1998-01-01"), "123");
            bool bo = emDAL.Insert(em);
            Assert.IsTrue(bo);

            em = new Employee("001", "啊三", 1, Convert.ToDateTime("1998-01-01"), "123");
            bool bo2 = emDAL.Insert(em);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            em = new Employee();
            em.EmployeeID = "001";
            bool bo = emDAL.Delete(em);
            Assert.IsTrue(bo);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            em = new Employee("001", "啊三", 1, Convert.ToDateTime("1998-01-01"), "123");
            bool bo = emDAL.Update(em);
            Assert.IsTrue(bo);

            em = new Employee("008", "啊三", 1, Convert.ToDateTime("1998-01-01"), "123");
            bool bo2 = emDAL.Update(em);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            Assert.AreEqual("啊三", emDAL.FindByID("001").EmployeeName.Trim());

            Assert.IsNull(emDAL.FindByID("008"));
        }
    }
}
