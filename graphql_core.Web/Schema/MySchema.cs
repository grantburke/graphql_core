using GraphQL;
using GraphQL.Types;
using graphql_core.Queries;

namespace graphql_core.Schema
{
    public class MySchema : GraphQL.Types.Schema
    {
        public MySchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<MyQuery>();
        }
    }
}