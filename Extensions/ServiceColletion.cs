using GraphQL.Data;
using GraphQL.GraphQL;
using GraphQL.Root;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Extensions;

public static class ServiceColletion
{
    public static IServiceCollection AddContext(this IServiceCollection services)
    {
        services.AddDbContext<Context>(option => option
            .UseInMemoryDatabase("pessoas")
            .LogTo(Console.WriteLine));

        return services;
    }
    public static IServiceCollection AddAppGraphQL(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddQueryType<RootQueryQL>().AddMutationType<RootMutationQL>()
            .AddTypeExtension<PessoaQueryQL>().AddTypeExtension<PessoaMutationQL>()
            .AddProjections()
            .AddFiltering()
            .AddSorting();

        return services;
    }
}
