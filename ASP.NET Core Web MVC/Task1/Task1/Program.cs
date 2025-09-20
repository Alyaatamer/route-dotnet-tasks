namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            #region Minimal API
            ////default route
            //app.MapGet("/", () => "Hello World!");

            ////static segment
            //app.MapGet("/Alyaa", () => "Hello Alyaa!");

            ////dynamic segment
            //app.MapGet("/{name}", async context =>
            //{
            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {name}!");
            //});

            ////Mixed segment
            //app.MapGet("/welcome/{name}", async context =>
            //{
            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Welcome {name}!");
            //}); 
            #endregion

            app.UseRouting(); // middleware -> routing table
            app.UseStaticFiles(); // middleware -> wwwroot

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );


            app.Run();
        }
    }
}
