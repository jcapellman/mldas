using Westwind.AspNetCore.Markdown;

namespace MLDas.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddMarkdown();
            builder.Services.AddControllers();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMarkdown();

            app.UseRouting();
            
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}