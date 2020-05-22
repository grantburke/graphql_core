using GraphQL.Types;
using graphql_core.Data.Models;

namespace graphql_core.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(f => f.Id);
            Field(f => f.FirstName);
            Field(f => f.LastName);
            Field(f => f.Quotes, type: typeof(ListGraphType<QuoteType>));
        }
    }
}