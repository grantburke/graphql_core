using System.Collections;
using System.Collections.Generic;
using GraphQL.Language.AST;
using GraphQL.Types;

namespace graphql_core.Types
{
    public class MyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class MyGraphType : ObjectGraphType<MyType>
    {
        public MyGraphType()
        {
            Field(f => f.Id);
            Field(f => f.Name);
            Field(f => f.Description);
        }
    }
}