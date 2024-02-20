using examenvar1.Models;
using Microsoft.EntityFrameworkCore;

namespace examenvar1.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Grupa> Grupe { get; set; }
    }
}
