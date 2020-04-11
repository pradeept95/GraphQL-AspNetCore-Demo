using App.GraphQL.Type;
using GraphQL;
using GraphQL.Http;
using GraphQL.Server;
using Microsoft.Extensions.DependencyInjection;

namespace App.GraphQL.Config
{
    public static class ServiceRegistrar
    {
        public static void RegisterGraphQLServices(this IServiceCollection services)
        {
            services.AddTransient<AppSchema>();
            services.AddTransient<IDependencyResolver>(
                serviceProvider => {
                    return new FuncDependencyResolver(serviceProvider.GetRequiredService);
                });

            services.AddGraphQL(o => { o.ExposeExceptions = true; })
                 .AddGraphTypes(ServiceLifetime.Scoped);

            services.AddTransient<AppQueryType>();
            services.AddTransient<AppMutationType>();


            //services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            //services.AddSingleton<IDocumentWriter, DocumentWriter>();

        } 
    }
}
