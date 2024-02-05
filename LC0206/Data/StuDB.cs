using Microsoft.EntityFrameworkCore;

namespace a
{
    public class StuDB:DbContext
    {
        // define database table 
        public DbSet<Student> students { get; set; } //One table in the database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          
            options.UseSqlite("Data Source=Students.db");// Data Source=path to the database file
        }
    }
}