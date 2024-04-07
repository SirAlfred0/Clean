

using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Clean.Application.Extentions;

public static class Extentions
{
    public static void AddApplication(this IServiceCollection services) =>
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
}
