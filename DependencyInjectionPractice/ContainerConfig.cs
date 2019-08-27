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
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Library.Utilities.BetterMarketplace>().As<Library.Utilities.IMarketplace>();
            builder.RegisterType<Library.Utilities.Hand>().As<Library.Utilities.IHand>();
            builder.RegisterType<Library.Utilities.Cart>().As<Library.Utilities.ICart>();

            return builder.Build();
        } 
    }
}
