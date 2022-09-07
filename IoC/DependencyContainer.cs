using Core.Services;
using Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Core.Interfaces.Repositories;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Infrastructure.Data.Database;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<MyBankContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
             
            services.AddScoped<ICartaoCreditoRepository, CartaoCreditoRepository>();

            services.AddScoped<ICartaoCreditoServices, CartaoCreditoServices>();



        }

    }
}