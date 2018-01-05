using System.Data.Entity;

namespace MvcDemoTutorial.Models
{
    public class ResumeDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Skills> Skills { get; set; }
    }
}