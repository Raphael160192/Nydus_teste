using CadastroFuncionários.Data;
using CadastroFuncionários.Interfaces;
using CadastroFuncionários.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CadastroFuncionários
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
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IHistoricoCargoRepository, HistoricoCargoRepository>();

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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "empresaCreate",
                    pattern: "empresa/create",
                    defaults: new { controller = "Empresa", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "empresaIndex",
                    pattern: "empresa",
                    defaults: new { controller = "Empresa", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "empresaEdit",
                    pattern: "empresa/edit/{id}",
                    defaults: new { controller = "Empresa", action = "Edit" });

                endpoints.MapControllerRoute(
                    name: "empresaDelete",
                    pattern: "empresa",
                    defaults: new { controller = "Empresa", action = "DeleteConfirmed" });

                endpoints.MapControllerRoute(
                    name: "cargoCreate",
                    pattern: "cargo/create",
                    defaults: new { controller = "Cargo", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "cargoIndex",
                    pattern: "cargo",
                    defaults: new { controller = "Cargo", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "cargoEdit",
                    pattern: "cargo/edit/{id}",
                    defaults: new { controller = "Cargo", action = "Edit" });

                endpoints.MapControllerRoute(
                    name: "cargoDelete",
                    pattern: "cargo/delete/{id}",
                    defaults: new { controller = "Cargo", action = "Delete" });

                endpoints.MapControllerRoute(
                    name: "ColaboradorCreate",
                    pattern: "Colaborador/create",
                    defaults: new { controller = "Colaborador", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "ColaboradorIndex",
                    pattern: "Colaborador",
                    defaults: new { controller = "Colaborador", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "ColaboradorEdit",
                    pattern: "Colaborador/edit/{id}",
                    defaults: new { controller = "Colaborador", action = "Edit" });

                endpoints.MapControllerRoute(
                    name: "ColaboradorDelete",
                    pattern: "Colaborador/delete/{id}",
                    defaults: new { controller = "Colaborador", action = "Delete" });

                endpoints.MapControllerRoute(
                    name: "HistoricoCargoIndex",
                    pattern: "HistoricoCargo",
                    defaults: new { controller = "HistoricoCargo", action = "Index" });


            });
        }
    }
}
