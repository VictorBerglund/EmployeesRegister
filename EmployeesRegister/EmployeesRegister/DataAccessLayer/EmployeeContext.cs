using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesRegister.DataAccessLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base()
        {
            string DefultConnection;
        }

        public DbSet<Models.Employee> Employee { get; set; }
    }
}