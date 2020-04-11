using Application.Data.Model;
using GraphQL.Types;

namespace App.GraphQL.Type
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Field(x => x.Id).Description("Id of and Address");
            Field(x => x.AddressLine1).Description("Address line 1.");
            Field(x => x.AddressLine2).Description("address line 2.");
            Field(x => x.City).Description("City.");
            Field(x => x.State).Description("state");
            Field(x => x.ZipCode).Description("Zip code.");
        }
    }
}
