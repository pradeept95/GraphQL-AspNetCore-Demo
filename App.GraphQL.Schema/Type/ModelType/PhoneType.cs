using Application.Data.Model;
using GraphQL.Types;

namespace App.GraphQL.Type
{
    public class PhoneType : ObjectGraphType<PhoneNumber>
    {
        public PhoneType()
        {
            Field(x => x.Id).Description("Id.");
            Field(x => x.PhNumber).Description("Phone number.");
        } 
    }
}
