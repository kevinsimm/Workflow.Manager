using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Manager.Bussiness.Interfaces;
using Workflow.Manager.Bussiness.Services;
using Workflow.Manager.Repository.Interface;
using Workflow.Manager.Repository.Repository;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services
            services.AddTransient<IUsersService, UsersService>();

            //repositories
            services.AddTransient<IUsersRepository, UsersRepository>();

            return services;
        }
    }
}
