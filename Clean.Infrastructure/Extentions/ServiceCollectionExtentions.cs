

using Clean.Application.interfaces;
using Clean.Infrastructure.Persistence;
using Clean.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Infrastructure.Extentions;

public static class ServiceCollectionExtentions
{
    public static void AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<CleanDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CleanDb")));

        service.AddScoped<IEmploymentRepository, EmploymentRepository>();
    }
}
