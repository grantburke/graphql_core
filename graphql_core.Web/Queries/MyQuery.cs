using System.Collections.Generic;
using GraphQL.Types;
using graphql_core.Types;

namespace graphql_core.Queries
{
    public class MyQuery : ObjectGraphType
    {
        public MyQuery()
        {
            Name = "MyQuery";
            Field<StringGraphType>("hello", resolve: ctx => "Hello, World!");
            Field<ListGraphType<StringGraphType>>("mylist", resolve: ctx => new List<string> {"one", "two", "three"});
            Field<ListGraphType<MyGraphType>>("types", resolve: ctx =>
            {
                return new List<MyType>
                {
                    new MyType {Id = 1, Name = "Type 1", Description = "Description 1"},
                    new MyType {Id = 2, Name = "Type 2", Description = "Description 2"},
                    new MyType {Id = 3, Name = "Type 3", Description = "Description 3"}
                };
            });
        }
    }
}