using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using RegerBiblioteca.App.Services;
using RegerBiblioteca.App.Services.Interfaces;
using RegerBiblioteca.App.Validators.Autores;

namespace RegerBiblioteca.App
{
    public static class AppModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddServices()
                .AddValidation();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAutorService, AutorService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IEmprestimoService, EmprestimoService>();

            return services;
        }
        private static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services
                .AddFluentValidationAutoValidation()
                .AddValidatorsFromAssemblyContaining<CreateAutorInputModelValidator>();

            return services;
        }
    }
}
