using Microsoft.EntityFrameworkCore;
using Moodle.DAL.Seeders;
using Moodle.Domain.entities;

public class MoodleContext : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }

    public DbSet<Cursus> Cursus { get; set; }
    public DbSet<Courses> Courses { get; set; }
    public DbSet<Module> Module { get; set; }
    public DbSet<Assessment> Assessments { get; set; }
    public DbSet<AssessmentResult> AssessmentResults { get; set; }
  
    public MoodleContext(DbContextOptions options): base(options) { }     
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Roles>().HasData(DataSeeders.InitRoles());
        modelBuilder.Entity<Cursus>().HasData(DataSeeders.InitCursus());
        modelBuilder.Entity<Users>().HasData(DataSeeders.InitUsers());
        modelBuilder.Entity<Courses>().HasData(DataSeeders.InitCourses());
        modelBuilder.Entity<Module>().HasData(DataSeeders.InitModules());
    }
}

