using System.Collections.Generic;

namespace graphql_core.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Quote> Quote { get; set; }
    }
}