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
    public class CustomerDALTests : ServicedComponent
    {
        [TestCleanup]
        public void TransactionOptionTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }

        CustomerDAL cuDAL;
        Customer cu;
        public CustomerDALTests()
        {
            cuDAL=new CustomerDAL();
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Customer> list = new List<Customer>();
            list = cuDAL.GetList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("001", list[0].CustomerID.Trim());
            Assert.AreEqual("安静", list[0].CustomerName.Trim());
        }

        [TestMethod()]
        public void InsertTest()
        {
            cu = new Customer("003", "安静","333","柳州","123","123456789","888","光大银行","5","规范","123@qq.com");
            bool bo = cuDAL.Insert(cu);
            Assert.IsTrue(bo);

            cu = new Customer("001", "安静", "333", "柳州", "123", "123456789", "888", "光大银行", "5", "规范", "123@qq.com");
            bool bo2 = cuDAL.Insert(cu);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            cu = new Customer();
            cu.CustomerID = "001";
            bool bo = cuDAL.Delete(cu);
            Assert.IsTrue(bo);

            cu = new Customer();
            cu.CustomerID = "003";
            bool bo2 = cuDAL.Delete(cu);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            cu = new Customer("001", "安静", "333", "柳州", "123", "123456789", "888", "光大银行", "5", "规范", "123@qq.com");
            bool bo = cuDAL.Update(cu);
            Assert.IsTrue(bo);

            cu = new Customer("003", "安静", "333", "柳州", "123", "123456789", "888", "光大银行", "5", "规范", "123@qq.com");
            bool bo2 = cuDAL.Update(cu);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            Assert.AreEqual("安静", cuDAL.FindByID("001").CustomerName.Trim());

            Assert.IsNull(cuDAL.FindByID("005"));
        }
    }
}
