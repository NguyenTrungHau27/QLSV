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
    public class UnitTestDKMH : SqlDatabaseTestClass
    {

        public UnitTestDKMH()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_AddToDKTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CheckClassTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_DeleteFromDKTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_FindSubjectTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetInfoTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumDeleteFromDK;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaDeleteFromDK;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestDKMH));
            this.dbo_AddToDKTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_CheckClassTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_DeleteFromDKTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_FindSubjectTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_GetInfoTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_AddToDKTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_CheckClassTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_DeleteFromDKTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_FindSubjectTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_GetInfoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            emptyResultSetGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            checksumFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            emptyResultSetFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            checksumDeleteFromDK = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            expectedSchemaDeleteFromDK = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            checksumCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            emptyResultSetCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            // 
            // dbo_AddToDKTestData
            // 
            this.dbo_AddToDKTestData.PosttestAction = null;
            this.dbo_AddToDKTestData.PretestAction = null;
            this.dbo_AddToDKTestData.TestAction = dbo_AddToDKTest_TestAction;
            // 
            // dbo_AddToDKTest_TestAction
            // 
            dbo_AddToDKTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_AddToDKTest_TestAction.Conditions.Add(expectedSchemaCondition1);
            resources.ApplyResources(dbo_AddToDKTest_TestAction, "dbo_AddToDKTest_TestAction");
            // 
            // dbo_CheckClassTestData
            // 
            this.dbo_CheckClassTestData.PosttestAction = null;
            this.dbo_CheckClassTestData.PretestAction = null;
            this.dbo_CheckClassTestData.TestAction = dbo_CheckClassTest_TestAction;
            // 
            // dbo_CheckClassTest_TestAction
            // 
            dbo_CheckClassTest_TestAction.Conditions.Add(checksumCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(emptyResultSetCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(expectedSchemaCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(notEmptyResultSetCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(rowCountCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(scalarValueCheckClass);
            resources.ApplyResources(dbo_CheckClassTest_TestAction, "dbo_CheckClassTest_TestAction");
            // 
            // dbo_DeleteFromDKTestData
            // 
            this.dbo_DeleteFromDKTestData.PosttestAction = null;
            this.dbo_DeleteFromDKTestData.PretestAction = null;
            this.dbo_DeleteFromDKTestData.TestAction = dbo_DeleteFromDKTest_TestAction;
            // 
            // dbo_DeleteFromDKTest_TestAction
            // 
            dbo_DeleteFromDKTest_TestAction.Conditions.Add(checksumDeleteFromDK);
            dbo_DeleteFromDKTest_TestAction.Conditions.Add(expectedSchemaDeleteFromDK);
            resources.ApplyResources(dbo_DeleteFromDKTest_TestAction, "dbo_DeleteFromDKTest_TestAction");
            // 
            // dbo_FindSubjectTestData
            // 
            this.dbo_FindSubjectTestData.PosttestAction = null;
            this.dbo_FindSubjectTestData.PretestAction = null;
            this.dbo_FindSubjectTestData.TestAction = dbo_FindSubjectTest_TestAction;
            // 
            // dbo_FindSubjectTest_TestAction
            // 
            dbo_FindSubjectTest_TestAction.Conditions.Add(checksumFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(emptyResultSetFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(expectedSchemaFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(notEmptyResultSetFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(rowCountFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(scalarValueFindSubject);
            resources.ApplyResources(dbo_FindSubjectTest_TestAction, "dbo_FindSubjectTest_TestAction");
            // 
            // dbo_GetInfoTestData
            // 
            this.dbo_GetInfoTestData.PosttestAction = null;
            this.dbo_GetInfoTestData.PretestAction = null;
            this.dbo_GetInfoTestData.TestAction = dbo_GetInfoTest_TestAction;
            // 
            // dbo_GetInfoTest_TestAction
            // 
            dbo_GetInfoTest_TestAction.Conditions.Add(checksumGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(emptyResultSetGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(expectedSchemaGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(notEmptyResultSetGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(rowCountGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(scalarValueGetInfo);
            resources.ApplyResources(dbo_GetInfoTest_TestAction, "dbo_GetInfoTest_TestAction");
            // 
            // checksumGetInfo
            // 
            checksumGetInfo.Checksum = "432775949";
            checksumGetInfo.Enabled = false;
            checksumGetInfo.Name = "checksumGetInfo";
            // 
            // emptyResultSetGetInfo
            // 
            emptyResultSetGetInfo.Enabled = false;
            emptyResultSetGetInfo.Name = "emptyResultSetGetInfo";
            emptyResultSetGetInfo.ResultSet = 1;
            // 
            // expectedSchemaGetInfo
            // 
            expectedSchemaGetInfo.Enabled = true;
            expectedSchemaGetInfo.Name = "expectedSchemaGetInfo";
            resources.ApplyResources(expectedSchemaGetInfo, "expectedSchemaGetInfo");
            expectedSchemaGetInfo.Verbose = false;
            // 
            // notEmptyResultSetGetInfo
            // 
            notEmptyResultSetGetInfo.Enabled = true;
            notEmptyResultSetGetInfo.Name = "notEmptyResultSetGetInfo";
            notEmptyResultSetGetInfo.ResultSet = 1;
            // 
            // rowCountGetInfo
            // 
            rowCountGetInfo.Enabled = true;
            rowCountGetInfo.Name = "rowCountGetInfo";
            rowCountGetInfo.ResultSet = 1;
            rowCountGetInfo.RowCount = 1;
            // 
            // scalarValueGetInfo
            // 
            scalarValueGetInfo.ColumnNumber = 1;
            scalarValueGetInfo.Enabled = true;
            scalarValueGetInfo.ExpectedValue = "Mai Lâm Tấn Đạt";
            scalarValueGetInfo.Name = "scalarValueGetInfo";
            scalarValueGetInfo.NullExpected = false;
            scalarValueGetInfo.ResultSet = 1;
            scalarValueGetInfo.RowNumber = 1;
            // 
            // checksumFindSubject
            // 
            checksumFindSubject.Checksum = "-34885523";
            checksumFindSubject.Enabled = false;
            checksumFindSubject.Name = "checksumFindSubject";
            // 
            // emptyResultSetFindSubject
            // 
            emptyResultSetFindSubject.Enabled = false;
            emptyResultSetFindSubject.Name = "emptyResultSetFindSubject";
            emptyResultSetFindSubject.ResultSet = 1;
            // 
            // expectedSchemaFindSubject
            // 
            expectedSchemaFindSubject.Enabled = true;
            expectedSchemaFindSubject.Name = "expectedSchemaFindSubject";
            resources.ApplyResources(expectedSchemaFindSubject, "expectedSchemaFindSubject");
            expectedSchemaFindSubject.Verbose = false;
            // 
            // notEmptyResultSetFindSubject
            // 
            notEmptyResultSetFindSubject.Enabled = true;
            notEmptyResultSetFindSubject.Name = "notEmptyResultSetFindSubject";
            notEmptyResultSetFindSubject.ResultSet = 1;
            // 
            // rowCountFindSubject
            // 
            rowCountFindSubject.Enabled = true;
            rowCountFindSubject.Name = "rowCountFindSubject";
            rowCountFindSubject.ResultSet = 1;
            rowCountFindSubject.RowCount = 1;
            // 
            // scalarValueFindSubject
            // 
            scalarValueFindSubject.ColumnNumber = 2;
            scalarValueFindSubject.Enabled = true;
            scalarValueFindSubject.ExpectedValue = "Cơ sở dữ liệu";
            scalarValueFindSubject.Name = "scalarValueFindSubject";
            scalarValueFindSubject.NullExpected = false;
            scalarValueFindSubject.ResultSet = 1;
            scalarValueFindSubject.RowNumber = 1;
            // 
            // checksumDeleteFromDK
            // 
            checksumDeleteFromDK.Checksum = "-1113720315";
            checksumDeleteFromDK.Enabled = false;
            checksumDeleteFromDK.Name = "checksumDeleteFromDK";
            // 
            // expectedSchemaDeleteFromDK
            // 
            expectedSchemaDeleteFromDK.Enabled = true;
            expectedSchemaDeleteFromDK.Name = "expectedSchemaDeleteFromDK";
            resources.ApplyResources(expectedSchemaDeleteFromDK, "expectedSchemaDeleteFromDK");
            expectedSchemaDeleteFromDK.Verbose = false;
            // 
            // checksumCheckClass
            // 
            checksumCheckClass.Checksum = "1659998681";
            checksumCheckClass.Enabled = false;
            checksumCheckClass.Name = "checksumCheckClass";
            // 
            // emptyResultSetCheckClass
            // 
            emptyResultSetCheckClass.Enabled = false;
            emptyResultSetCheckClass.Name = "emptyResultSetCheckClass";
            emptyResultSetCheckClass.ResultSet = 1;
            // 
            // expectedSchemaCheckClass
            // 
            expectedSchemaCheckClass.Enabled = true;
            expectedSchemaCheckClass.Name = "expectedSchemaCheckClass";
            resources.ApplyResources(expectedSchemaCheckClass, "expectedSchemaCheckClass");
            expectedSchemaCheckClass.Verbose = false;
            // 
            // notEmptyResultSetCheckClass
            // 
            notEmptyResultSetCheckClass.Enabled = true;
            notEmptyResultSetCheckClass.Name = "notEmptyResultSetCheckClass";
            notEmptyResultSetCheckClass.ResultSet = 1;
            // 
            // rowCountCheckClass
            // 
            rowCountCheckClass.Enabled = true;
            rowCountCheckClass.Name = "rowCountCheckClass";
            rowCountCheckClass.ResultSet = 1;
            rowCountCheckClass.RowCount = 1;
            // 
            // scalarValueCheckClass
            // 
            scalarValueCheckClass.ColumnNumber = 1;
            scalarValueCheckClass.Enabled = true;
            scalarValueCheckClass.ExpectedValue = "TH01";
            scalarValueCheckClass.Name = "scalarValueCheckClass";
            scalarValueCheckClass.NullExpected = false;
            scalarValueCheckClass.ResultSet = 1;
            scalarValueCheckClass.RowNumber = 1;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "-1113720315";
            checksumCondition1.Enabled = false;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
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
        public void dbo_AddToDKTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_AddToDKTestData;
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

        [TestMethod()]
        public void dbo_CheckClassTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_CheckClassTestData;
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

        [TestMethod()]
        public void dbo_DeleteFromDKTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_DeleteFromDKTestData;
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

        [TestMethod()]
        public void dbo_FindSubjectTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_FindSubjectTestData;
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

        [TestMethod()]
        public void dbo_GetInfoTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_GetInfoTestData;
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
        private SqlDatabaseTestActions dbo_AddToDKTestData;
        private SqlDatabaseTestActions dbo_CheckClassTestData;
        private SqlDatabaseTestActions dbo_DeleteFromDKTestData;
        private SqlDatabaseTestActions dbo_FindSubjectTestData;
        private SqlDatabaseTestActions dbo_GetInfoTestData;
    }
}
