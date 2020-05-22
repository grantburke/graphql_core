using System.Collections;
using System.Collections.Generic;
using GraphQL.Language.AST;
using GraphQL.Types;
using graphql_core.Data.Models;

namespace graphql_core.Types
{
    public class QuoteType : ObjectGraphType<Quote>
    {
        public QuoteType()
        {
            Field(f => f.Id);
            Field(f => f.Phrase);
            Field(f => f.Emoji);
            Field(f => f.EmployeeId);
            Field(f => f.Employee, type: typeof(EmployeeType));
        }
    }
}