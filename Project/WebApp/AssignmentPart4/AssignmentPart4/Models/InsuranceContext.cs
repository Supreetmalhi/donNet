using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssignmentPart4.Models
{
   
    public class InsuranceContext : DbContext
    {
        public InsuranceContext() : base("InsuranceDB")
        {
            Database.SetInitializer<InsuranceContext>(new InsuranceDBInitializer());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Adds configurations for Student from separate class
        //    modelBuilder.Configurations.Add(new StudentConfigurations());

        //    modelBuilder.Entity<Teacher>()
        //        .ToTable("TeacherInfo");

        //    modelBuilder.Entity<Teacher>()
        //        .MapToStoredProcedures();
        //}

        public DbSet<Insurance> Insurance { get; set; }
    }
}