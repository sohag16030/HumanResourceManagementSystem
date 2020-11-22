using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Web.Models
{
    public static class ModelBuliderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Superadmin",
                   Email = "superadmin@gmail.com",
                   Department = Dept.HR
               },
               new Employee
               {
                   Id = 2,
                   Name = "Admin",
                   Email = "admin@gmail.com",
                   Department = Dept.IT
               }
          );
        }
    }
}
