using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Onion_PersonelGorevlendirmeSistemi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_PersonelGorevlendirmeSistemi.Persistance
{
    public static class ServiceRegistirations
    {
        public static  void AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<TaskManagementContext>(builder =>
            {
                builder.UseSqlServer(configuration.GetConnectionString("Local"));
            });
        }
    }
}
