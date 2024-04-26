using Microsoft.EntityFrameworkCore;
using TodoAPP.Models;

namespace TodoAPP.Context
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Todo;Trusted_connection=true;Encrypt=false");
        }
    }
}
