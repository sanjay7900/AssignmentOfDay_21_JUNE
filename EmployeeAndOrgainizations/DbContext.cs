using EmployeeAndOrgainizations.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndOrgainizations
{
    public class DbContextFile:DbContext
    {
        public DbSet<Employee> Employees { set; get; }
        public DbSet<EmployeeOrganizations> Organizations { set; get; }
        public DbContextFile()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AMR2CQS\MSSQLSERVER01;Initial Catalog=EFCORE_ENTITIES;Integrated Security=True");
        }
       
    }
}
