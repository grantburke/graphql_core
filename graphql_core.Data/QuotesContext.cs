using graphql_core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql_core.Data
{
    public class QuotesContext : DbContext
    {
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=quotes.db");

    }
}