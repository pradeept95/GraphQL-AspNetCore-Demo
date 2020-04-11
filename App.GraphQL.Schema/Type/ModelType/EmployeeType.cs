using Application.Data.Model;
using GraphQL.Types;

namespace App.GraphQL.Type
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(x => x.Id).Description("Id of an Employee.");
            Field(x => x.FirstName).Description("First Name Of an Employee.");
            Field(x => x.LastName).Description("Last Name Of an Employee."); 
            Field<ListGraphType<AddressType>>("Addresses", "Addresses of and employee"); 
            Field<ListGraphType<PhoneType>>("Phones", "Phone numbers of an employee");
            Field<ListGraphType<EmailAddressType>>("EmailAddresses", "Emails of and employee");
        }
    }
}
