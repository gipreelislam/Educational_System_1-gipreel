using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EducationalSystem.Models.Context
{
    public class Education_System:IdentityDbContext<ApplicationUser>
    {
        public Education_System() : base()
        {

        }
        public Education_System(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Course_Enrollments> Course_Enrollments { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Assessments> Assessments { get; set; }
        public DbSet<Assessment_Results> Assessment_Results { get; set; }
        public DbSet<Choices> Choices { get; set; }
        public DbSet<Lesson_Completions> Lesson_Completions { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Progress> progresses { get; set; }
        public DbSet<Questions> Questions  { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}
