using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MyTask> MyTask { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
