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
    [TestClass()]
    public class PurchaseBillDALTests
    {
        private PurchaseBill pur;
        private PurchaseBillDAL purDAL;
        private PurchaseDetail detail;
        public PurchaseBillDALTests()
        {
            purDAL = new PurchaseBillDAL()
 ;
        }
        [TestMethod()]
        public void FindPurchaseIDByPurchaseIDTest()
        {
            List<string> list = new List<string>();
            list = purDAL.FindPurchaseIDByPurchaseID("2017");
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("201700000", list[0]);
            Assert.AreEqual("201703100", list[1]);
        }

        [TestMethod()]
        public void FindPurchaseIDByClerkTest()
        {
            List<string> list = new List<string>();
            list = purDAL.FindPurchaseIDByClerk("安静");
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("201600000", list[0]);
            Assert.AreEqual("201700000", list[1]);
        }

        [TestMethod()]
        public void FindPurchaseIDByExaminerTest()
        {
            List<string> list = new List<string>();
            list = purDAL.FindPurchaseIDByExaminer("啊三");
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("201700000", list[0]);
            Assert.AreEqual("201703100", list[1]);
        }

        [TestMethod()]
        public void FindPurchaseIDByOnProcessTest()
        {
            List<string> list = new List<string>();
            list = purDAL.FindPurchaseIDByOnProcess(0);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("201703100", list[0]);
        }

        [TestMethod()]
        public void FindPurchaseIDByPurchaseDateTest()
        {
            List<string> list = new List<string>();
            list = purDAL.FindPurchaseIDByPurchaseDate(Convert.ToDateTime("2019-08-08"), Convert.ToDateTime("2019-08-08"));
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("201600000", list[0]);
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            Assert.AreEqual("001", purDAL.FindByID("201703100").SupplierID.Trim());
            Assert.AreEqual(1, purDAL.FindByID("201703100").DetailList.Count);
            Assert.AreEqual(100, purDAL.FindByID("201703100").DetailList[0].PurchasePrice);

            Assert.IsNull(purDAL.FindByID("201703"));

        }

        [TestMethod()]
        public void InsertTest()
        {

            List<PurchaseDetail> detailList = new List<PurchaseDetail>();
            detail = new PurchaseDetail("20180202001", 1, "002", 66, 23);
            detailList.Add(detail);

            pur = new PurchaseBill("20180202001", "002", Convert.ToDateTime("2018-2-2"),DateTime.MinValue, "001", "", "",0 , "", detailList);
            bool b = purDAL.Insert(pur);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            List<PurchaseDetail> detailList = new List<PurchaseDetail>();
            detail = new PurchaseDetail("20180202001", 1, "002", 66, 23);
            detailList.Add(detail);
            detail = new PurchaseDetail("20180202001", 2, "003", 56, 23);
            detailList.Add(detail);

            pur = new PurchaseBill("20180202001", "001", Convert.ToDateTime("2018-2-2"), DateTime.MinValue, "001", "", "", 0, "", detailList);
            
            bool b = purDAL.Update(pur);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void UpdateDetailOnlyTest()
        {
            pur = purDAL.FindByID("20180202001");
            pur.OnProcess = 1;
            pur.Memo = "123";
            bool b = purDAL.UpdateDetailOnly(pur);
            Assert.IsTrue(b);
        }

        [TestMethod()]
        public void CreatePurchaseIDTest()
        {
            string date=purDAL.CreatePurchaseID(Convert.ToDateTime("2016-1-1"));
            Assert.AreEqual("201601010008", date);
        }
    }
}
