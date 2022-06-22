using Microsoft.Extensions.DependencyInjection;
using NuLab.Domain.Interfaces;
using NuLab.Infra.Ioc;

class Program
{
    protected Program()
    {
    }
    static void Main(string[] args)
    {
        var serviceProvider = Configure();

        Console.Write("Digite um numero: ");
        int valor = Int16.Parse(Console.ReadLine());
        
        var useCase = serviceProvider.GetRequiredService<IPrimeNumberCheckerUseCase>();
        Console.WriteLine(useCase.Execute(valor).ToString());
        
        Console.ReadKey();
    }

    private static ServiceProvider Configure()
    {
        ServiceProvider serviceProvider = new ServiceCollection()
            .Register()
            .BuildServiceProvider();

        return serviceProvider;
    }
}