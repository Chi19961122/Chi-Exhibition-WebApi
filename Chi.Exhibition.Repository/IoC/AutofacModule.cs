using Autofac;
using Castle.DynamicProxy;
using System.Reflection;
using Autofac.Extras.DynamicProxy;
using Chi.Exhibition.Repository.Attributes.Autofac;

namespace Chi.Exhibition.Repository.IoC
{
    public class SwaggerModule : Autofac.Module
    {
        /// <summary>
        /// 載入DI Container
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            Assembly[] domainAssembly = new Assembly[] { Assembly.Load("PChome.Wms.Domain") };

            LifetimeRegistry(builder, domainAssembly);

            Assembly[] infrastructureAssembly = new Assembly[] { Assembly.Load("PChome.Wms.Infrastructure") };

            LifetimeRegistry(builder, infrastructureAssembly);

            builder.RegisterAssemblyTypes(infrastructureAssembly)
                .AssignableTo(typeof(IInterceptor));

            Assembly[] serviceAssembly = new Assembly[] { Assembly.Load("PChome.Wms.Service") };

            builder.RegisterAssemblyTypes(serviceAssembly)
                .Where(t => t.GetCustomAttribute<PerLifetimeScopeServiceAttribute>() != null)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope()
                .PropertiesAutowired()
                .EnableInterfaceInterceptors()
                ;
        }

        /// <summary>
        /// 生命週期註冊
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="assembly"></param>
        private void LifetimeRegistry(ContainerBuilder builder, Assembly[] assembly)
        {
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.GetCustomAttribute<PerLifetimeScopeServiceAttribute>() != null)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope()
                .PropertiesAutowired();

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.GetCustomAttribute<SingleServiceAttribute>() != null)
                .AsImplementedInterfaces()
                .SingleInstance()
                .PropertiesAutowired();
        }
    }
}
