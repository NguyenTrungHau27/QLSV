using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLSV;
using System.Data;

namespace UnitTest
{
    [TestClass]
    public class UnitTestTimLichThi
    {
        private Check MH;
        [TestInitialize]
        public void setup()
        {
            MH = new Check("1551010032");
        }
        [TestMethod]
        public void CheckMaMH()
        {
            Assert.AreEqual(MH.CheckMaMH("111"), true);
            Assert.AreEqual(MH.CheckMaMH("12345678901"), false);
            Assert.AreEqual(MH.CheckMaMH(""), false);
            Assert.AreEqual(MH.CheckMaMH(null), false);
        }
        [TestMethod]
        public void TestTimMonHoc()
        {
            //Assert.Equals(MH.CheckMaMH("000"), null);
        }
    }
}
