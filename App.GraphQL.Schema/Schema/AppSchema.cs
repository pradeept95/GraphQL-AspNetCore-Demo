using App.GraphQL.Type;
using GraphQL;
using GraphQL.Conversion;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQueryType>(); 
            Mutation = resolver.Resolve<AppMutationType>();
        } 
    }
}
