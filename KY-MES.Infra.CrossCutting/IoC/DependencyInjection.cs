using KY_MES.Services;
using KY_MES.Services.DomainServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KY_MES.Infra.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection LoadDependencyInjection(this IServiceCollection services)
        {
            services.AddSingleton<IMESService, MESService>();

            return services;
        }
    }
}
