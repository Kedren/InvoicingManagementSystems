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
    public class SupplierDALTests: ServicedComponent
    {
        [TestCleanup]
        public void TransactionOptionTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }
        SupplierDAL suDAL;
        Supplier su;
        public SupplierDALTests()
        {
            suDAL = new SupplierDAL();

        }
    
        [TestMethod()]
        public void GetListTest()
        {
            List<Supplier> list = new List<Supplier>();
            list = suDAL.GetList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("001", list[0].SupID.Trim());
            Assert.AreEqual("安静", list[0].SupName.Trim());
        }

        [TestMethod()]
        public void InsertTest()
        {
            su = new Supplier("003","阿卡","CS","aaaas","55","456789","axa","开发银行","xac","s5s","123@qq.com");
            bool bo =suDAL.Insert(su);
            Assert.IsTrue(bo);

            su = new Supplier("001", "阿卡", "CS", "aaaas", "55", "456789", "axa", "开发银行", "xac", "s5s", "123@qq.com");
            bool bo2 = suDAL.Insert(su);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            su = new Supplier();
            su.SupID = "001";
            bool bo = suDAL.Delete(su);
            Assert.IsTrue(bo);

            su = new Supplier();
            su.SupID = "003";
            bool bo2 = suDAL.Delete(su);
            Assert.IsFalse(bo2);

        }

        [TestMethod()]
        public void UpdateTest()
        {
            su = new Supplier("001","阿卡","CS","aaaas","55","456789","axa","开发银行","xac","s5s","123@qq.com");
            bool bo =suDAL.Update(su);
            Assert.IsTrue(bo);

            su = new Supplier("003", "阿卡", "CS", "aaaas", "55", "456789", "axa", "开发银行", "xac", "s5s", "123@qq.com");
            bool bo2 = suDAL.Update(su);
            Assert.IsFalse(bo2);       
        }

        [TestMethod()]
        public void FindByIDTest()
        {

            Assert.AreEqual("安静",suDAL.FindByID("001").SupName.Trim());

            Assert.IsNull(suDAL.FindByID("008"));
        }
    }
}
