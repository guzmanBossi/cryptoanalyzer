﻿using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace ALoGaucho.CryptoAnalyzer.Domain
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerDependency();
        }

    }
}
