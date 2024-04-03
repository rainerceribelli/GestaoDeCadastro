using GestaoDeCadastro.Infraestructure.Model;
using GestaoDeCadastro.Infraestructure.Persistance.EntityFramework;
using GestaoDeCadastro.Infraestructure.Persistance.Repository;
using GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro;
using GestaoDeCadastro.Service.ApplicationServices.Cadastro;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeCadastro.Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<GenericContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Context"));
            });

            builder.Services.AddScoped<GestaoDeCadastroModel>(); // Assuming IGestaoDeCadastroModel is the interface

            builder.Services.AddControllers();
            builder.Services.AddScoped<PessoaUnitOfWork>();
            builder.Services.AddScoped<PessoaJuridicaUnitOfWork>();
            builder.Services.AddScoped<PessoaFisicaUnitOfWork>();
            builder.Services.AddScoped<PessoaRepository>();
            builder.Services.AddScoped<PessoaFisicaRepository>();
            builder.Services.AddScoped<PessoaJuridicaRepository>();
            builder.Services.AddScoped<PessoaApplicationServices>();
            builder.Services.AddScoped<PessoaFisicaApplicationServices>();
            builder.Services.AddScoped<PessoaJuridicaApplicationServices>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var devCorsPolicy = "devCorsPolicy";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(devCorsPolicy, builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "GestaoDeCadastro");
                });
                app.UseCors(devCorsPolicy);
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }

    }
}