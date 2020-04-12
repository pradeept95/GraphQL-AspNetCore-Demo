using GraphQL.Types;

namespace App.GraphQL.Type
{
    public class PagedRequestType : InputObjectGraphType<PagedRequest>
    {
        public PagedRequestType()
        {
            Field(x => x.SearchText).Description("Search Term");
            Field(x => x.PageSize).Description("Page Size");
            Field(x => x.PageNumber).Description("Current Page Number");
        }
    }

    public class PagedRequest
    {
        public PagedRequest()
        {
            SearchText = "";
            PageSize = 10;
            PageNumber = 1;
        }

        public string SearchText { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; } 
    }
}
