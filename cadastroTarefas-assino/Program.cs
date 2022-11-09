using cadastroTarefas_assino.Data;
using cadastroTarefas_assino.Repository;
using Microsoft.EntityFrameworkCore;

namespace cadastroTarefas_assino
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddDbContext<BancoContext>(opt => 
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
            builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}