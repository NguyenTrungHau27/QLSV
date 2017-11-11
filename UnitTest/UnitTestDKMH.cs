using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumAddToDK;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaAddToDK;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestDKMH));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_CheckClassTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCheckClass;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_DeleteFromDKTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumDeleteFromDK;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaDeleteFromDK;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_FindSubjectTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaFindSubject;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetInfoTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueGetInfo;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaGetInfo;
            this.dbo_AddToDKTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_CheckClassTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_DeleteFromDKTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_FindSubjectTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_GetInfoTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_AddToDKTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumAddToDK = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            expectedSchemaAddToDK = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_CheckClassTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            emptyResultCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            notEmptyResultSetCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCheckClass = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_DeleteFromDKTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumDeleteFromDK = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            expectedSchemaDeleteFromDK = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_FindSubjectTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            emptyResultSetFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            notEmptyResultSetFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaFindSubject = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_GetInfoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            emptyResultSetGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            notEmptyResultSetGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaGetInfo = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            // 
            // dbo_AddToDKTest_TestAction
            // 
            dbo_AddToDKTest_TestAction.Conditions.Add(checksumAddToDK);
            dbo_AddToDKTest_TestAction.Conditions.Add(expectedSchemaAddToDK);
            resources.ApplyResources(dbo_AddToDKTest_TestAction, "dbo_AddToDKTest_TestAction");
            // 
            // checksumAddToDK
            // 
            checksumAddToDK.Checksum = "-1113720315";
            checksumAddToDK.Enabled = true;
            checksumAddToDK.Name = "checksumAddToDK";
            // 
            // expectedSchemaAddToDK
            // 
            expectedSchemaAddToDK.Enabled = false;
            expectedSchemaAddToDK.Name = "expectedSchemaAddToDK";
            resources.ApplyResources(expectedSchemaAddToDK, "expectedSchemaAddToDK");
            expectedSchemaAddToDK.Verbose = false;
            // 
            // dbo_CheckClassTest_TestAction
            // 
            dbo_CheckClassTest_TestAction.Conditions.Add(checksumCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(emptyResultCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(notEmptyResultSetCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(rowCountCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(scalarValueCheckClass);
            dbo_CheckClassTest_TestAction.Conditions.Add(expectedSchemaCheckClass);
            resources.ApplyResources(dbo_CheckClassTest_TestAction, "dbo_CheckClassTest_TestAction");
            // 
            // checksumCheckClass
            // 
            checksumCheckClass.Checksum = "1742788472";
            checksumCheckClass.Enabled = false;
            checksumCheckClass.Name = "checksumCheckClass";
            // 
            // emptyResultCheckClass
            // 
            emptyResultCheckClass.Enabled = false;
            emptyResultCheckClass.Name = "emptyResultCheckClass";
            emptyResultCheckClass.ResultSet = 1;
            // 
            // notEmptyResultSetCheckClass
            // 
            notEmptyResultSetCheckClass.Enabled = false;
            notEmptyResultSetCheckClass.Name = "notEmptyResultSetCheckClass";
            notEmptyResultSetCheckClass.ResultSet = 1;
            // 
            // rowCountCheckClass
            // 
            rowCountCheckClass.Enabled = false;
            rowCountCheckClass.Name = "rowCountCheckClass";
            rowCountCheckClass.ResultSet = 1;
            rowCountCheckClass.RowCount = 1;
            // 
            // scalarValueCheckClass
            // 
            scalarValueCheckClass.ColumnNumber = 1;
            scalarValueCheckClass.Enabled = false;
            scalarValueCheckClass.ExpectedValue = null;
            scalarValueCheckClass.Name = "scalarValueCheckClass";
            scalarValueCheckClass.NullExpected = true;
            scalarValueCheckClass.ResultSet = 1;
            scalarValueCheckClass.RowNumber = 1;
            // 
            // expectedSchemaCheckClass
            // 
            expectedSchemaCheckClass.Enabled = true;
            expectedSchemaCheckClass.Name = "expectedSchemaCheckClass";
            resources.ApplyResources(expectedSchemaCheckClass, "expectedSchemaCheckClass");
            expectedSchemaCheckClass.Verbose = false;
            // 
            // dbo_DeleteFromDKTest_TestAction
            // 
            dbo_DeleteFromDKTest_TestAction.Conditions.Add(checksumDeleteFromDK);
            dbo_DeleteFromDKTest_TestAction.Conditions.Add(expectedSchemaDeleteFromDK);
            resources.ApplyResources(dbo_DeleteFromDKTest_TestAction, "dbo_DeleteFromDKTest_TestAction");
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
            // dbo_FindSubjectTest_TestAction
            // 
            dbo_FindSubjectTest_TestAction.Conditions.Add(checksumFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(emptyResultSetFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(notEmptyResultSetFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(rowCountFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(scalarValueFindSubject);
            dbo_FindSubjectTest_TestAction.Conditions.Add(expectedSchemaFindSubject);
            resources.ApplyResources(dbo_FindSubjectTest_TestAction, "dbo_FindSubjectTest_TestAction");
            // 
            // checksumFindSubject
            // 
            checksumFindSubject.Checksum = "-1113720315";
            checksumFindSubject.Enabled = false;
            checksumFindSubject.Name = "checksumFindSubject";
            // 
            // emptyResultSetFindSubject
            // 
            emptyResultSetFindSubject.Enabled = false;
            emptyResultSetFindSubject.Name = "emptyResultSetFindSubject";
            emptyResultSetFindSubject.ResultSet = 1;
            // 
            // notEmptyResultSetFindSubject
            // 
            notEmptyResultSetFindSubject.Enabled = false;
            notEmptyResultSetFindSubject.Name = "notEmptyResultSetFindSubject";
            notEmptyResultSetFindSubject.ResultSet = 1;
            // 
            // rowCountFindSubject
            // 
            rowCountFindSubject.Enabled = false;
            rowCountFindSubject.Name = "rowCountFindSubject";
            rowCountFindSubject.ResultSet = 1;
            rowCountFindSubject.RowCount = 1;
            // 
            // scalarValueFindSubject
            // 
            scalarValueFindSubject.ColumnNumber = 1;
            scalarValueFindSubject.Enabled = false;
            scalarValueFindSubject.ExpectedValue = "";
            scalarValueFindSubject.Name = "scalarValueFindSubject";
            scalarValueFindSubject.NullExpected = false;
            scalarValueFindSubject.ResultSet = 1;
            scalarValueFindSubject.RowNumber = 1;
            // 
            // expectedSchemaFindSubject
            // 
            expectedSchemaFindSubject.Enabled = true;
            expectedSchemaFindSubject.Name = "expectedSchemaFindSubject";
            resources.ApplyResources(expectedSchemaFindSubject, "expectedSchemaFindSubject");
            expectedSchemaFindSubject.Verbose = false;
            // 
            // dbo_GetInfoTest_TestAction
            // 
            dbo_GetInfoTest_TestAction.Conditions.Add(checksumGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(emptyResultSetGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(notEmptyResultSetGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(rowCountGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(scalarValueGetInfo);
            dbo_GetInfoTest_TestAction.Conditions.Add(expectedSchemaGetInfo);
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
            // notEmptyResultSetGetInfo
            // 
            notEmptyResultSetGetInfo.Enabled = true;
            notEmptyResultSetGetInfo.Name = "notEmptyResultSetGetInfo";
            notEmptyResultSetGetInfo.ResultSet = 1;
            // 
            // rowCountGetInfo
            // 
            rowCountGetInfo.Enabled = false;
            rowCountGetInfo.Name = "rowCountGetInfo";
            rowCountGetInfo.ResultSet = 1;
            rowCountGetInfo.RowCount = 1;
            // 
            // scalarValueGetInfo
            // 
            scalarValueGetInfo.ColumnNumber = 1;
            scalarValueGetInfo.Enabled = false;
            scalarValueGetInfo.ExpectedValue = "Mai Lâm Tấn Đạt";
            scalarValueGetInfo.Name = "scalarValueGetInfo";
            scalarValueGetInfo.NullExpected = false;
            scalarValueGetInfo.ResultSet = 1;
            scalarValueGetInfo.RowNumber = 1;
            // 
            // expectedSchemaGetInfo
            // 
            expectedSchemaGetInfo.Enabled = true;
            expectedSchemaGetInfo.Name = "expectedSchemaGetInfo";
            resources.ApplyResources(expectedSchemaGetInfo, "expectedSchemaGetInfo");
            expectedSchemaGetInfo.Verbose = false;
            // 
            // dbo_AddToDKTestData
            // 
            this.dbo_AddToDKTestData.PosttestAction = null;
            this.dbo_AddToDKTestData.PretestAction = null;
            this.dbo_AddToDKTestData.TestAction = dbo_AddToDKTest_TestAction;
            // 
            // dbo_CheckClassTestData
            // 
            this.dbo_CheckClassTestData.PosttestAction = null;
            this.dbo_CheckClassTestData.PretestAction = null;
            this.dbo_CheckClassTestData.TestAction = dbo_CheckClassTest_TestAction;
            // 
            // dbo_DeleteFromDKTestData
            // 
            this.dbo_DeleteFromDKTestData.PosttestAction = null;
            this.dbo_DeleteFromDKTestData.PretestAction = null;
            this.dbo_DeleteFromDKTestData.TestAction = dbo_DeleteFromDKTest_TestAction;
            // 
            // dbo_FindSubjectTestData
            // 
            this.dbo_FindSubjectTestData.PosttestAction = null;
            this.dbo_FindSubjectTestData.PretestAction = null;
            this.dbo_FindSubjectTestData.TestAction = dbo_FindSubjectTest_TestAction;
            // 
            // dbo_GetInfoTestData
            // 
            this.dbo_GetInfoTestData.PosttestAction = null;
            this.dbo_GetInfoTestData.PretestAction = null;
            this.dbo_GetInfoTestData.TestAction = dbo_GetInfoTest_TestAction;
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
