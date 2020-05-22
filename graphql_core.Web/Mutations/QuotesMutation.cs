using GraphQL.Types;
using graphql_core.Data.Models;
using graphql_core.Service;
using graphql_core.Types;

namespace graphql_core.Mutations
{
    public class QuotesMutation : ObjectGraphType
    {
        private const string _quoteArgName = "quote";
        public QuotesMutation(IQuoteService quoteSvc, IEmployeeService employeeSvc)
        {
            Name = "QuotesMutation";
            Field<QuoteType>(
                "addQuote",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<AddQuoteRequest>> { Name = _quoteArgName }),
                resolve: ctx => 
                {
                    var quote = ctx.GetArgument<Quote>(_quoteArgName);
                    return quoteSvc.Create(quote);
                });
        }
    }
}