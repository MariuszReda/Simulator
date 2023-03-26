using Autofac;
using Simulator.Contracts;
using Simulator.Implementations;
using Simulator.Mapper;


namespace Simulator
{
    public static class ServiceProvider
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Implementations.Mapper>().As<IMapper>();
            builder.RegisterType<JsonData>().As<IJsonData>();
            return builder.Build();
        }
    }
}
