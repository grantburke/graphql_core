using System.Collections.Generic;
using GraphQL.Types;
using graphql_core.Service;
using graphql_core.Types;

namespace graphql_core.Queries
{
    public class QuotesQuery : ObjectGraphType
    {
        public QuotesQuery(IQuoteService quoteSvc, IEmployeeService employeeSvc)
        {
            Name = "QuotesQuery";
            Field<ListGraphType<QuoteType>>("quotes", resolve: ctx => quoteSvc.GetAllWithEmployees());
            Field<QuoteType>(
                "quote",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: ctx => 
                {
                    var id = ctx.GetArgument<int>("id");
                    return quoteSvc.GetById(id);
                });
            Field<ListGraphType<EmployeeType>>("employees", resolve: ctx => employeeSvc.GetAllWithQuotes());
        }
    }
}