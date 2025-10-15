using Microsoft.AspNetCore.Http.Json;
using RegerBiblioteca.API.Converters;
using RegerBiblioteca.App;
using RegerBiblioteca.Infra;
namespace RegerBiblioteca.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Adiciona CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost", policy =>
                    policy
                        //.WithOrigins("http://localhost:5500") // Porta do Live Server
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            // registra o converter
            builder.Services.Configure<JsonOptions>(options =>
            {
                options.SerializerOptions.Converters.Add(new SenhaJsonConverter());
            });


            // Add services to the container.
            builder.Services
                .AddApplication()
                .AddInfra(builder.Configuration);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // 2. Usa o CORS
            app.UseCors("AllowLocalhost");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
