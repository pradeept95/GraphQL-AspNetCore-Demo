using GraphQL.Types;

namespace App.GraphQL.Type
{
    public class AppMutationType : ObjectGraphType
    {
        public AppMutationType()
        {
            Name = "Mutation";
        }
    }

}
