using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenApplication.Test
{
    [TestClass]
    public class EmployeeTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient",
                    "data source=VENKAT-PC\\VENKATPC;database=TestDB;integrated security=true",
                    "Employees", DataAccessMethod.Sequential)]
        public void DataDrivenEmployeeTest()
        {
            Employee employee = new Employee();
            employee.Name = TestContext.DataRow["Name"].ToString();
            employee.Email = TestContext.DataRow["Email"].ToString();
            Assert.IsNotNull(employee.Name);
            Assert.IsNotNull(employee.Email);
        }
    }
}
