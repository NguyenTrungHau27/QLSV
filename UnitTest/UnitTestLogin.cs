using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLSV;
using System.Data.SqlClient;
using System.Data;

namespace UnitTest
{
    [TestClass]
    public class UnitTestLogin:DangNhapTK 
    {
        private DangNhapTK dn;
        [TestInitialize]
        public void setup()
        {
            dn = new DangNhapTK();
        }
        [TestMethod]
        public void TestCheckUser()
        {
            Assert.AreEqual(dn.CheckUser("1551010032"), true);
            Assert.AreEqual(dn.CheckUser("155101003"), false);
            Assert.AreEqual(dn.CheckUser("15510100321"), false);
            Assert.AreEqual(dn.CheckUser(null), false);
            Assert.AreEqual(dn.CheckUser(""), false);
            Assert.AreEqual(dn.CheckUser("1551010032H"), false);
            Assert.AreEqual(dn.CheckUser("@1551010032"), false);
        }


    }
}
