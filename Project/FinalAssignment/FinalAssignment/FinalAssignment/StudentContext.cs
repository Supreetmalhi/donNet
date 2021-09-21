using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class StudentContext: DbContext
    {
        public StudentContext() : base("StudentDB")
        {
            Database.SetInitializer<StudentContext>(new SchoolDBInitializer());
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

        public DbSet<Student> Students { get; set; }
    }
}
