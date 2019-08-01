using Autofac;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Library.BusinessLogic>().As<Library.IBusinessLogic>();
            builder.RegisterType<Library.Utilities.Marketplace>().As<Library.Utilities.IMarketplace>();
            builder.RegisterType<Library.Utilities.Hand>().As<Library.Utilities.IHand>();
            builder.RegisterType<Library.Utilities.Cart>().As<Library.Utilities.ICart>();

            //builder.RegisterType<Application>().As<IApplication>();
            //builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Library)))
            //    .Where(t => t.Namespace.Contains("Utilities"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        } 
    }
}
