using Microservices01.Common.Services;
using Microservices01.Services.Test;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices01.Services;

public static class Extensions
{
  public static void RegisterBusinessServices (this IServiceCollection services)
  {
    services.AddScoped<ITestService, TestService> ();
  }
}