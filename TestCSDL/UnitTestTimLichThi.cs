using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCSDL
{
    [TestClass()]
    public class UnitTestTimLichThi : SqlDatabaseTestClass
    {

        public UnitTestTimLichThi()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_TimLichThiTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestTimLichThi));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition SoLuongHangKetQua;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckMSSV;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckPhongThi;
            this.dbo_TimLichThiTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_TimLichThiTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            SoLuongHangKetQua = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckMSSV = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckPhongThi = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_TimLichThiTest_TestAction
            // 
            dbo_TimLichThiTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_TimLichThiTest_TestAction.Conditions.Add(SoLuongHangKetQua);
            dbo_TimLichThiTest_TestAction.Conditions.Add(CheckMSSV);
            dbo_TimLichThiTest_TestAction.Conditions.Add(CheckPhongThi);
            resources.ApplyResources(dbo_TimLichThiTest_TestAction, "dbo_TimLichThiTest_TestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "1147688446";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // SoLuongHangKetQua
            // 
            SoLuongHangKetQua.Enabled = true;
            SoLuongHangKetQua.Name = "SoLuongHangKetQua";
            SoLuongHangKetQua.ResultSet = 1;
            SoLuongHangKetQua.RowCount = 1;
            // 
            // dbo_TimLichThiTestData
            // 
            this.dbo_TimLichThiTestData.PosttestAction = null;
            this.dbo_TimLichThiTestData.PretestAction = null;
            this.dbo_TimLichThiTestData.TestAction = dbo_TimLichThiTest_TestAction;
            // 
            // CheckMSSV
            // 
            CheckMSSV.ColumnNumber = 2;
            CheckMSSV.Enabled = true;
            CheckMSSV.ExpectedValue = "1551010032";
            CheckMSSV.Name = "CheckMSSV";
            CheckMSSV.NullExpected = false;
            CheckMSSV.ResultSet = 1;
            CheckMSSV.RowNumber = 1;
            // 
            // CheckPhongThi
            // 
            CheckPhongThi.ColumnNumber = 5;
            CheckPhongThi.Enabled = true;
            CheckPhongThi.ExpectedValue = "105";
            CheckPhongThi.Name = "CheckPhongThi";
            CheckPhongThi.NullExpected = false;
            CheckPhongThi.ResultSet = 1;
            CheckPhongThi.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_TimLichThiTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_TimLichThiTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_TimLichThiTestData;
    }
}
