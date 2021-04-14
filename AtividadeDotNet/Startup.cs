using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using AtividadeDotNet.context;
using AtividadeDotNet.Services;
using AtividadeDotNet.UseCase;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.Repositorios;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.Adapter;

namespace AtividadeDotNet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("urlSquadra")));
            services.AddScoped<ISapatoService, SapatoService>();
            services.AddScoped<IAdicionarSapatoUseCase, AdicionarSapatoUseCase>();
            services.AddScoped<IAtualizarSapatoUseCase, AtualizarSapatoUseCase>();
            services.AddScoped<IRemoverSapatoUseCase, RemoverSapatoUseCase>();
            services.AddScoped<IRetornarListaSapatosUseCase, RetornarListaSapatosUseCase>();
            services.AddScoped<IRetornarSapatoPorIDUseCase, RetornarSapatoPorIDUseCase>();
            services.AddScoped<IRepositorioSapatos, RepositorioSapatos>();
            services.AddScoped<IAdicionarSapatoAdapter, AdicionarSapatoAdapter>();
            services.AddScoped<IAtualizarSapatoAdapter, AtualizarSapatoAdapter>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AtividadeDotNET", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AtividadeDotNET v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
