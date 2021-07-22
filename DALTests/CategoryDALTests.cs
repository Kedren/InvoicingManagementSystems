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
    public class CategoryDALTests : ServicedComponent
    {
        [TestCleanup]
        public void TransactionOptionTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }

        CategoryDAL caDAL;
        Category ca;
        public CategoryDALTests()
        {
            caDAL = new CategoryDAL();

        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Category> list = new List<Category>();
            list = caDAL.GetList();
            Assert.AreEqual(5, list.Count);
            Assert.AreEqual("1", list[0].CateID.Trim());
            Assert.AreEqual("华为", list[0].CateName.Trim());
        }

        [TestMethod()]
        public void InsertTest()
        {
            ca = new Category("6", "苹果");
            bool bo = caDAL.Insert(ca);
            Assert.IsTrue(bo);

            ca = new Category("4", "苹果");
            bool bo1 = caDAL.Insert(ca);
            Assert.IsFalse(bo1);
        }

        [TestMethod()]
        public void DeletetTest()
        {
            ca = new Category("3", "魅族");
            bool bo = caDAL.Delete(ca);
            Assert.IsTrue(bo);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            ca = new Category("4", "苹果");
            bool bo = caDAL.Update(ca);
            Assert.IsTrue(bo);

            ca = new Category("6", "苹果");
            bool bo2 = caDAL.Update(ca);
            Assert.IsFalse(bo2);
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            Assert.AreEqual("小米", caDAL.FindByID("2").CateName.Trim());

            Assert.IsNull(caDAL.FindByID("6"));
        }

        [TestMethod()]
        public void GetCategoryByCategoryIDAndCategyNameTest()
        {
            Assert.Fail();
        }
    }
}
