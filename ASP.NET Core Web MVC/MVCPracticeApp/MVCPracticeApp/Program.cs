using Microsoft.EntityFrameworkCore;
using MVCApp.BLL.Services.Course;
using MVCApp.BLL.Services.Student;
using MVCApp.DAL.Contexts;
using MVCApp.DAL.Reposatories.GenericRepo;


namespace MVCPracticeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(Options =>
            {
                Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));

            //builder.Services.AddScoped<IStudentServices, StudentServices>();
            //builder.Services.AddScoped<ICourseServices, CourseServices>();
            //builder.Services.AddScoped<IInstructorService, InstructorService>();
            //builder.Services.AddScoped<IStudentCourseService, StudentCourseService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
          
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();


            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
