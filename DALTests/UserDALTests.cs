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
    public class UserDALTests : ServicedComponent
    {
        [TestCleanup]
        public void TransactionOptionTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }

        UserDAL usDAL;
        User us;
        public UserDALTests()
        {
            usDAL=new UserDAL();
            us = new User();
        }
       
        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindByIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void User_LoginTest()
        {
            us.UserID = "003";
            us.PassWord = "666666";
            Assert.IsTrue(usDAL.User_Login(us));
        }
    }
}
