using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

// to use dbcontext must identify the last namespace

namespace MVCDemo.Models
{
    public class EmployeeContext:DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}