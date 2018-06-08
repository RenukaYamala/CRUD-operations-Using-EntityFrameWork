using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_UsingEntityFrameWork.Models;

namespace Employee_UsingEntityFrameWork.Data
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
              optionsBuilder.UseSqlServer(" Server=RYAMALA01; Database=Employee; Trusted_Connection=True; MultipleActiveResultSets=true; ");
              optionsBuilder.UseSqlServer(" Server=RYAMALA01; Database=Employeeetails; Trusted_Connection=True; MultipleActiveResultSets=true; ");
            base.OnConfiguring(optionsBuilder);
        }

    }
}

