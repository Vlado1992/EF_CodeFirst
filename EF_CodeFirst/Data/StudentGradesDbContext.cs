using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data;

public class StudentGradesDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public DbSet<Grade> Grades { get; set; }

    public StudentGradesDbContext(DbContextOptions<StudentGradesDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seedanje
        modelBuilder.Entity<Student>().HasData(
            new Student { StudentID = 1, StudentName = "Pero Perić", DateOfBirth = new DateTime(2003, 10, 1), Height = 185.5m, Weight = 91.5f },
            new Student { StudentID = 2, StudentName = "Ana Anić", DateOfBirth = new DateTime(2004, 1, 15), Height = 167.5m, Weight = 62.3f }
        );

        modelBuilder.Entity<Grade>().HasData(
            new Grade { GradeId = 1, GradeName = "Odličan", Section = "Geografija", StudentId = 1 },
            new Grade { GradeId = 2, GradeName = "Vrlo dobar", Section = "Matematika", StudentId = 1 },
            new Grade { GradeId = 3, GradeName = "Odličan", Section = "Povijest", StudentId = 1 },
            new Grade { GradeId = 4, GradeName = "Dobar", Section = "Geografija", StudentId = 2 },
            new Grade { GradeId = 5, GradeName = "Vrlo dobar", Section = "Matematika", StudentId = 2 },
            new Grade { GradeId = 6, GradeName = "Odličan", Section = "Povijest", StudentId = 2 },
            new Grade { GradeId = 7, GradeName = "Dobar", Section = "Engleski jezik", StudentId = 2 }
        );

        base.OnModelCreating(modelBuilder);
    }
}
