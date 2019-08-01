using Autofac;
using ConsoleUI;
using System;

namespace DependencyInjectionPractice
{
    class Program
    {
        static void Main()
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                app.Run();
            }
            Console.ReadLine();
        }
    }
}
