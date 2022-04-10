using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTSSCoreMVC.Models;

namespace TTSSCoreMVC.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options){}

        public DbSet<Employee> Employees { get; set; }
    }
}
