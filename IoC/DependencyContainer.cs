using Core.Services;
using Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Core.Interfaces.Repositories;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

             
            services.AddScoped<ICartaoCreditoServices, CartaoCreditoServices>();


            services.AddScoped<ICartaoCreditoRepository, CartaoCreditoRepository>();

        }

    }
}