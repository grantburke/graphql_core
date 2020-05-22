using System.Collections.Generic;

namespace graphql_core.Data.Models
{
    public class Employee : TEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Quote> Quotes { get; set; }
    }
}