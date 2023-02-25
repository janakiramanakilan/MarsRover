using System;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILandingSurface, Plataeu>()
                .BuildServiceProvider();

            var commandCenter = new CommandCenter(serviceProvider);
            commandCenter.SendCommand("5 5");


            Console.ReadKey();
        }
    }
}
