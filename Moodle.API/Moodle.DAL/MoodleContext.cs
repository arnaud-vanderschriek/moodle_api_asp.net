using Microsoft.EntityFrameworkCore;
using Moodle.DAL.Seeders;
using Moodle.Domain.entities;

public class MoodleContext : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Courses> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Assessment> Assessments { get; set; }
    public DbSet<AssessmentResult> AssessmentResults { get; set; }
    public DbSet<LearningProgress> LearningProgress { get; set; }
  
    public MoodleContext(DbContextOptions options): base(options) { }     
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>().HasData(DataSeeders.InitUsers());
        modelBuilder.Entity<Roles>().HasData(DataSeeders.InitRoles());
        modelBuilder.Entity<Courses>().HasData(DataSeeders.InitCourses());
    }
}

