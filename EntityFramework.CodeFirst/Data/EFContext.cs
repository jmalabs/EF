using EntityFramework.CodeFirst.EntityConfigurations;
using EntityFramework.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst.Data
{
    public class EFContext : DbContext
    {

        public EFContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cover> Covers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CourseConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
