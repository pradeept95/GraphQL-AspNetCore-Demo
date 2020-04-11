using Application.Data.Model;
using GraphQL.Types;

namespace App.GraphQL.Type
{
    public class EmailAddressType : ObjectGraphType<EmailAddress>
    {
        public EmailAddressType()
        {
            Field(x => x.Id).Description("Id.");
            Field(x => x.Email).Description("Phone number.");
        }
    }
}
