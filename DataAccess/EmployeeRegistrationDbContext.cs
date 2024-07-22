using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

   
    public class EmployeeRegistrationDbContext :DbContext 
    {
        public EmployeeRegistrationDbContext(DbContextOptions<EmployeeRegistrationDbContext> options)
         : base(options)
        {

        }

       
        public DbSet<Person> Persons { get; set; }
        public DbSet<EducationHistory> EducationHistorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Employee");
            
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasMany(r => r.EducationHistory);
               
            });
        }
    }
}
