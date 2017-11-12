using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSDL
{
    [TestClass()]
    public class UnnitTestTimLichThi : SqlDatabaseTestClass
    {

        public UnnitTestTimLichThi()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnnitTestTimLichThi));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition MSSV;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition MaLop;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            this.dbo_TimLichThiTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_TimLichThiTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            MSSV = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            MaLop = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // dbo_TimLichThiTestData
            // 
            this.dbo_TimLichThiTestData.PosttestAction = null;
            this.dbo_TimLichThiTestData.PretestAction = null;
            this.dbo_TimLichThiTestData.TestAction = dbo_TimLichThiTest_TestAction;
            // 
            // dbo_TimLichThiTest_TestAction
            // 
            dbo_TimLichThiTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_TimLichThiTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_TimLichThiTest_TestAction.Conditions.Add(MSSV);
            dbo_TimLichThiTest_TestAction.Conditions.Add(MaLop);
            dbo_TimLichThiTest_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(dbo_TimLichThiTest_TestAction, "dbo_TimLichThiTest_TestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "1147688446";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // MSSV
            // 
            MSSV.ColumnNumber = 2;
            MSSV.Enabled = true;
            MSSV.ExpectedValue = "1551010032";
            MSSV.Name = "MSSV";
            MSSV.NullExpected = false;
            MSSV.ResultSet = 1;
            MSSV.RowNumber = 1;
            // 
            // MaLop
            // 
            MaLop.ColumnNumber = 1;
            MaLop.Enabled = true;
            MaLop.ExpectedValue = "TH01";
            MaLop.Name = "MaLop";
            MaLop.NullExpected = false;
            MaLop.ResultSet = 1;
            MaLop.RowNumber = 1;
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
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
