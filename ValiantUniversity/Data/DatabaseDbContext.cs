using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ValiantUniversity.Models;

namespace ValiantUniversity.Data
{
    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext (DbContextOptions<DatabaseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Instructor> Instructor{ get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<ValiantUniversity.Models.Course> Course { get; set; }
        public DbSet<ValiantUniversity.Models.Department> Department { get; set; }
    }
}
