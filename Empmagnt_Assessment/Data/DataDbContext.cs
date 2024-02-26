using Empmagnt_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Empmagnt_Assessment.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public DbSet<DepartmentInfo> DepartmentInfos { get; set; }
        public DbSet<EmployeeSalaryDetails> EmployeeSalaryDetails { get; set; }


    }

}
