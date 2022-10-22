using Microsoft.EntityFrameworkCore;

namespace CgpaProject.Models
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SecondSubject> SecondSubjects { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}

