using Gameapp.Services;

namespace Gameapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new WebApplicationBuilder instance to build the web application.
            var builder = WebApplication.CreateBuilder(args);

            // Add Razor Pages services to the container.
            builder.Services.AddRazorPages();

            // Register the GameServices class as a transient service in the dependency injection container.
            builder.Services.AddTransient<GameServices>();

            // Build the web application.
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            // Check if the application is running in a development environment.
            if (!app.Environment.IsDevelopment())
            {
                // If not in development, use the error handling middleware to handle exceptions and redirect to the error page.
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            // Use HTTPS redirection middleware to automatically redirect HTTP requests to HTTPS.
            app.UseHttpsRedirection();

            // Use static files middleware to serve static files from wwwroot folder.
            app.UseStaticFiles();

            // Use routing middleware to handle incoming HTTP requests and route them to the appropriate endpoints.
            app.UseRouting();

            // Use authorization middleware to authenticate and authorize users for accessing resources
            app.UseAuthorization();

            // Map Razor Pages middleware to handle incoming Razor Page requests.
            app.MapRazorPages();

            // Start the web application and listen for incoming requests.
            app.Run();
        }
    }
}
