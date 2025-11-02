using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.Seed;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Persistence.Contexts;
using ECommerce.Persistence.Seed;
using ECommerce.Persistence.UOW;
using ECommerce.Service.MappingProfiles;
using ECommerce.Service.Services;
using Microsoft.EntityFrameworkCore;

namespace ECommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<StoredDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IDataSeeding, DataSeeding>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IServicesManger,ServicesManger>();
            builder.Services.AddAutoMapper(m => m.AddProfile(new ProjectProfile(builder.Configuration)));

            var app = builder.Build();

            var Scope = app.Services.CreateScope();
            var ObjectSeeding = Scope.ServiceProvider.GetRequiredService<IDataSeeding>();

            ObjectSeeding.DataSeedAsync();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
