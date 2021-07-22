using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuQiJing.DBUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace LuQiJing.DBUtility.Tests
{
    [TestClass()]
    public class DBAccessTests
    {
        [TestMethod()]
        public void ExcuteReaderTest()
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_Category");
            SqlDataReader re= DBAccess.ExcuteReader(cmd);

            Assert.IsNotNull(re);
            re.Read();
            Assert.AreEqual("华为", re[1].ToString());
        }
    }
}
