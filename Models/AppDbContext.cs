
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutheDemo.Models
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                 new Employee()
                 {
                     Id = 1,
                     FullName = " Vu Duc Trung",
                     Department = ".Net IT",
                     Email = "trungvd@gemvietnam.com",
                     AvatarPath = "images/gem.png"
                 },

                new Employee()
                {
                    Id = 2,
                    FullName = " Nguyen Van Hung",
                    Department = ".Net IT",
                    Email = "hungnv@gemvietnam.com",
                    AvatarPath = "images/gem.png"
                },

                new Employee()
                {
                    Id = 3,
                    FullName = " Hoang Van Nam",
                    Department = ".Net IT",
                    Email = "Namhv@gemvietnam.com",
                    AvatarPath = "images/gem.png"
                },

                new Employee()
                {
                    Id = 4,
                    FullName = "Nguyen Quy Dat",
                    Department = "Java IT",
                    Email = "DatNQ@gemvietnam.com",
                    AvatarPath = "images/gem.png"
                },

                new Employee()
                {
                    Id = 5,
                    FullName = "Dao Ngoc Duy",
                    Department = "Java IT",
                    Email = "DuyDN@gemvietnam.com",
                    AvatarPath = "images/gem.png"
                },

                new Employee()
                {
                    Id = 6,
                    FullName = " Dao Duc Duyet",
                    Department = "Mobile IT",
                    Email = "DuyetDD@gemvietnam.com",
                    AvatarPath = "images/gem.png"
                },

                  new Employee()
                  {
                      Id = 7,
                      FullName = "Pham Thanh Dat",
                      Department = "Mobile IT",
                      Email = "DatPT@gemvietnam.com",
                      AvatarPath = "images/gem.png"
                  }
                );
        }
    }
}
