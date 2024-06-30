using System;
using EmployeeCRUDApplication.Models.Domain;
using Microsoft.EntityFrameworkCore;


namespace EmployeeCRUDApplication.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

