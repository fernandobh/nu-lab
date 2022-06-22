using Microsoft.Extensions.DependencyInjection;
using NuLab.Domain.Interfaces;
using NuLab.Gateway;

namespace NuLab.Infra.Ioc
{
    public static class RegistrationDependecy
    {
        public static void Register(this IServiceCollection service)
        {
            service.AddSingleton<IPrimeNumberCheckerUseCase, PrimeNumberCheckerUseCase>();
            service.AddSingleton<IAccountRepository, AccountRepository>();
            service.AddSingleton<IAccountServices, AccountServices>();
        }
    }
}