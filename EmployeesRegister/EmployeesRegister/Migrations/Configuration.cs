namespace EmployeesRegister.Migrations
{
    using EmployeesRegister.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeeContext context)
        {
            context.Employee.AddOrUpdate(
                e =>  new {e.Id, e.FirstName, e.LastName, e.Salary, e.Department, e.Position },
                new Employee { Id = 1, FirstName = "Bruce", LastName = "Wayne", Salary = 500000, Department = "Finance", Position = "CEO"},
                new Employee { Id = 2, FirstName = "Hal", LastName = "Jordon", Salary = 25000, Department = "Human Resources", Position = "Vice President" },
                new Employee { Id = 3, FirstName = "Diana", LastName = "Prince", Salary = 30000, Department = "Marketing", Position = "Director" },
                new Employee { Id = 4, FirstName = "Clark", LastName = "Kent", Salary = 18000, Department = "IT", Position = "Assistant" },
                new Employee { Id = 5, FirstName = "J'onn", LastName = "J'onzz", Salary = 24500, Department = "Accounting", Position = "CFO" }
                );


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
