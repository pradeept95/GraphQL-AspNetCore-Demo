using GraphQL.Types;
using System.Collections.Generic;

namespace App.GraphQL.Type
{
    public class PagedResponseType<T, TType> : ObjectGraphType<PagedResponse<T>>
        where TType : IGraphType
        where T : class
    {
        public PagedResponseType()
        {
            Field<ListGraphType<TType>>("Data", "List of Data");
            Field(x => x.TotalCount).Description("Total number of records.");
        }
    }

    public class PagedResponse<T> where T: class
    {
        public int TotalCount { get; set; }
        public List<T> Data { get; set; }
    }

}
