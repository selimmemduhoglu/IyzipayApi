using Autofac;
using IyzipayApi.Services;

namespace IyzipayApi.DependencyResolvers;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CreatePaymentService>().As<CreatePaymentService>().InstancePerLifetimeScope();

    }


}
