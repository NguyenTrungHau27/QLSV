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
    public class UnitTestXemLichThi : SqlDatabaseTestClass
    {

        public UnitTestXemLichThi()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_XemLichThiTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestXemLichThi));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition SoDong;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition MSSV_hang1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition MSSV_hang2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckPhong;
            this.dbo_XemLichThiTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_XemLichThiTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            SoDong = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            MSSV_hang1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            MSSV_hang2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckPhong = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_XemLichThiTest_TestAction
            // 
            dbo_XemLichThiTest_TestAction.Conditions.Add(SoDong);
            dbo_XemLichThiTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_XemLichThiTest_TestAction.Conditions.Add(MSSV_hang1);
            dbo_XemLichThiTest_TestAction.Conditions.Add(MSSV_hang2);
            dbo_XemLichThiTest_TestAction.Conditions.Add(CheckPhong);
            resources.ApplyResources(dbo_XemLichThiTest_TestAction, "dbo_XemLichThiTest_TestAction");
            // 
            // SoDong
            // 
            SoDong.Enabled = true;
            SoDong.Name = "SoDong";
            SoDong.ResultSet = 1;
            SoDong.RowCount = 2;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "1410574321";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // dbo_XemLichThiTestData
            // 
            this.dbo_XemLichThiTestData.PosttestAction = null;
            this.dbo_XemLichThiTestData.PretestAction = null;
            this.dbo_XemLichThiTestData.TestAction = dbo_XemLichThiTest_TestAction;
            // 
            // MSSV_hang1
            // 
            MSSV_hang1.ColumnNumber = 2;
            MSSV_hang1.Enabled = true;
            MSSV_hang1.ExpectedValue = "1551010032";
            MSSV_hang1.Name = "MSSV_hang1";
            MSSV_hang1.NullExpected = false;
            MSSV_hang1.ResultSet = 1;
            MSSV_hang1.RowNumber = 1;
            // 
            // MSSV_hang2
            // 
            MSSV_hang2.ColumnNumber = 2;
            MSSV_hang2.Enabled = true;
            MSSV_hang2.ExpectedValue = "1551010032";
            MSSV_hang2.Name = "MSSV_hang2";
            MSSV_hang2.NullExpected = false;
            MSSV_hang2.ResultSet = 1;
            MSSV_hang2.RowNumber = 2;
            // 
            // CheckPhong
            // 
            CheckPhong.ColumnNumber = 5;
            CheckPhong.Enabled = true;
            CheckPhong.ExpectedValue = "105";
            CheckPhong.Name = "CheckPhong";
            CheckPhong.NullExpected = false;
            CheckPhong.ResultSet = 1;
            CheckPhong.RowNumber = 1;
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
        public void dbo_XemLichThiTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_XemLichThiTestData;
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
        private SqlDatabaseTestActions dbo_XemLichThiTestData;
    }
}
