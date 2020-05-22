using GraphQL.Types;

namespace graphql_core.Mutations
{
    public class AddQuoteRequest : InputObjectGraphType
    {
        public AddQuoteRequest()
        {
            Name = "QuoteRequest";
            Field<NonNullGraphType<StringGraphType>>("phrase");
            Field<NonNullGraphType<StringGraphType>>("emoji");
            Field<NonNullGraphType<IntGraphType>>("employeeId");
        }
    }
}