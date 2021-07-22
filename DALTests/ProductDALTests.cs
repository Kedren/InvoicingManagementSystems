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
    public class ProductDALTests : ServicedComponent
    {
        [TestCleanup]
        public void TransactionOptionTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }

        ProductDAL prDAL;
        Product pr;
        public ProductDALTests()
        {
            prDAL = new ProductDAL();

        }


        [TestMethod()]
        public void GetListTest()
        {
            List<Product> list = new List<Product>();
            list = prDAL.GetList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("001", list[0].ProductID.Trim());
            Assert.AreEqual("西城", list[0].ProductName.Trim());
        }

        [TestMethod()]
        public void InsertTest()
        {
            pr = new Product("003","西城","艾玛","大","规范","3","55","4",19.20,18.60,55);
            bool bo = prDAL.Insert(pr);
            Assert.IsTrue(bo);

            pr = new Product("001", "十二", "123456", "44", "jsj", "46", "ksk", "1", 1.0, 2.0, 5);
            bool bo1 = prDAL.Insert(pr);
            Assert.IsFalse(bo1);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            pr = new Product();
            pr.ProductID = "001";
            bool bo = prDAL.Delete(pr);
            Assert.IsTrue(bo);

            pr = new Product();
            pr.ProductID = "003";
            bool bo2 = prDAL.Delete(pr);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            pr = new Product("001", "西城", "艾玛", "大", "规范", "3", "55", "4", 19.20, 18.60, 55);
            bool bo = prDAL.Update(pr);
            Assert.IsTrue(bo);

            pr = new Product("003", "十二", "123456", "44", "jsj", "46", "ksk", "1", 1.0, 2.0, 5);
            bool bo1 = prDAL.Update(pr);
            Assert.IsFalse(bo1);
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            Assert.AreEqual("西城", prDAL.FindByID("001").ProductName.Trim());

            Assert.IsNull(prDAL.FindByID("003"));
        }

        [TestMethod()]
        public void FindProductBySpellingCodeTest()
        {
            List<Product> list = new List<Product>();
            list = prDAL.FindProductBySpellingCode("A");
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("002", list[0].ProductID);
            Assert.AreEqual("安静", list[0].ProductName.Trim());
        }
    }
}
