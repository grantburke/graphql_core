using graphql_core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql_core.Data
{
    public class TodoContext : DbContext
    {
        public virtual DbSet<Todo> Todos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=todos.db");
        
    }
}