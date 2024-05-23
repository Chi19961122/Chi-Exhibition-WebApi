using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Chi.Exhibition.Repository.IoC
{
    public static class AutofacModuleRegister
    {
        /// <summary>
        /// 加入Autofac服務
        /// </summary>
        /// <param name="builder"></param>
        public static void AddAutofac(this WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(autofac => autofac.RegisterModule(new SwaggerModule()));
        }
    }
}
