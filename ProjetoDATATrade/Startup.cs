using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoDATATrade.Data;
using ProjetoDATATrade.Libs.Sessao;
using ProjetoDATATrade.Libs.LoginLibs;
using ProjetoDATATrade.Repositories;
using ProjetoDATATrade.Repositories.Interfaces;

namespace ProjetoDATATrade
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
            //Services das repository e interfaces
            services.AddHttpContextAccessor();
            services.AddScoped<ICarteiraRep, CarteiraRep>();
            services.AddScoped<IEstrategiaRep, EstrategiaRep>();
            services.AddScoped<IIndicadorRep, IndicadorRep>();
            services.AddScoped<ILoginRep, LoginRep>();
            services.AddScoped<IOperacaoRep, OperacaoRep>();
            services.AddScoped<ITraderRep, TraderRep>();
            services.AddScoped<IUsuarioRep, UsuarioRep>();
            //services do banco de dados
            services.AddDbContext<IESContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnectionString")));
            services.AddControllersWithViews();
            //Services da Sessao
            services.AddMemoryCache();
            services.AddSession(options =>
            {

            });
            services.AddScoped<Sessao>();
            services.AddScoped<LoginUsuario>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Authentication}/{action=Login}/{id?}");
            });
        }
    }
}
