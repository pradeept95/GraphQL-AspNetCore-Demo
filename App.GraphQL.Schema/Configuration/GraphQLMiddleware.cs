using Microsoft.AspNetCore.Builder;
using GraphQL.Server.Ui.Playground;
using GraphQL.Server;

namespace App.GraphQL.Config
{ 
    public static class AppMiddleware
    { 
        public static IApplicationBuilder UseAppGraphQL(this IApplicationBuilder app) 
        { 
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions 
            {  
                Path = "/playground"
            });
            app.UseGraphQL<AppSchema>(); 
            return app;
        }
    } 
}
