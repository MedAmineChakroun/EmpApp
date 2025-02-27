using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JokesApp.Models;

namespace JokesApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<JokesApp.Models.Employee> Employee { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890", Position = "Software Engineer", Salary = 60000, DateOfHire = new DateTime(2020, 5, 10), IsActive = true },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "9876543210", Position = "Project Manager", Salary = 75000, DateOfHire = new DateTime(2019, 8, 15), IsActive = true },
                new Employee { Id = 3, FirstName = "Michael", LastName = "Johnson", Email = "michael.johnson@example.com", PhoneNumber = "1112223333", Position = "QA Engineer", Salary = 50000, DateOfHire = new DateTime(2021, 3, 1), IsActive = true },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Davis", Email = "emily.davis@example.com", PhoneNumber = "4445556666", Position = "HR Manager", Salary = 65000, DateOfHire = new DateTime(2018, 7, 20), IsActive = true },
                new Employee { Id = 5, FirstName = "Robert", LastName = "Miller", Email = "robert.miller@example.com", PhoneNumber = "7778889999", Position = "Data Analyst", Salary = 70000, DateOfHire = new DateTime(2022, 1, 10), IsActive = true }
            );
        }
    }

}
