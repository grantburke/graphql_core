using GraphQL;
using GraphQL.Types;
using graphql_core.Queries;

namespace graphql_core.Schema
{
    public class QuotesSchema : GraphQL.Types.Schema
    {
        public QuotesSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<QuotesQuery>();
        }
    }
}