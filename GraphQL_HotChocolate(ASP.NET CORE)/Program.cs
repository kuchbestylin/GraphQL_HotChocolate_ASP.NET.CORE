using GraphQL_HotChocolate_ASP.NET_CORE_.GraphQL;
using GraphQL_HotChocolate_ASP.NET_CORE_.Models;
using GraphQL_HotChocolate_ASP.NET_CORE_.Services;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_HotChocolate_ASP.NET_CORE_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigurationManager configuration = builder.Configuration;
            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("connection"));
            });
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services
                .AddScoped<Query>()
                .AddScoped<Mutation>()
                .AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
            var app = builder.Build();
            app.MapGraphQL("/api");
            app.Run();
        }
    }
}