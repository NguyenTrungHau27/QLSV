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
    public class TestDangNhap : SqlDatabaseTestClass
    {

        public TestDangNhap()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_TestDangNhapTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDangNhap));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition KhongCoGiaTriNullTraVe;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition TraVeMSSV;
            this.dbo_TestDangNhapTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_TestDangNhapTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            KhongCoGiaTriNullTraVe = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            TraVeMSSV = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_TestDangNhapTestData
            // 
            this.dbo_TestDangNhapTestData.PosttestAction = null;
            this.dbo_TestDangNhapTestData.PretestAction = null;
            this.dbo_TestDangNhapTestData.TestAction = dbo_TestDangNhapTest_TestAction;
            // 
            // dbo_TestDangNhapTest_TestAction
            // 
            dbo_TestDangNhapTest_TestAction.Conditions.Add(KhongCoGiaTriNullTraVe);
            dbo_TestDangNhapTest_TestAction.Conditions.Add(TraVeMSSV);
            resources.ApplyResources(dbo_TestDangNhapTest_TestAction, "dbo_TestDangNhapTest_TestAction");
            // 
            // KhongCoGiaTriNullTraVe
            // 
            KhongCoGiaTriNullTraVe.Enabled = true;
            KhongCoGiaTriNullTraVe.Name = "KhongCoGiaTriNullTraVe";
            KhongCoGiaTriNullTraVe.ResultSet = 1;
            // 
            // TraVeMSSV
            // 
            TraVeMSSV.ColumnNumber = 1;
            TraVeMSSV.Enabled = true;
            TraVeMSSV.ExpectedValue = "1551010046";
            TraVeMSSV.Name = "TraVeMSSV";
            TraVeMSSV.NullExpected = false;
            TraVeMSSV.ResultSet = 1;
            TraVeMSSV.RowNumber = 1;
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
        public void dbo_TestDangNhapTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_TestDangNhapTestData;
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
        private SqlDatabaseTestActions dbo_TestDangNhapTestData;
    }
}
