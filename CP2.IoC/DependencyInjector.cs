using CP2.Application.Services;
using CP2.Domain.Interfaces;
using CP2.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using CP2.Data.AppData;

namespace CP2.IoC
{
    public static class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Registro dos Application Services
            services.AddScoped<IFornecedorApplicationService, FornecedorApplicationService>();
            services.AddScoped<IVendedorApplicationService, VendedorApplicationService>();

            // Registro dos Repositories
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IVendedorRepository, VendedorRepository>();

            // Outros serviços, como o contexto de banco de dados, se necessário
            services.AddDbContext<ApplicationContext>(); // Exemplo, caso tenha um ApplicationContext
        }
    }
}
