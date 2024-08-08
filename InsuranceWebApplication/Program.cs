using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace InsuranceWebApplication
{
    public class Program
    {
        private const string ConnectionStringName = "InsuranceWebApplication";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            builder.Services.AddSingleton<IConfiguration>(options =>
            {
                var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Local.json", true)
                .AddEnvironmentVariables();
                return configurationBuilder.Build();
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            
            builder.Services.AddDbContext<IAppDbContext, AppDbContext>(options =>
            {
                string dbConnectionString = builder.Configuration.GetConnectionString(ConnectionStringName)!;
                options.UseSqlServer(dbConnectionString, dbOptions =>
                {
                    dbOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.GetName().Name);
                });
            });

            var app = builder.Build();
            using (IServiceScope scope = app.Services.CreateScope())
            {
                try
                {
                    AppDbContext? dbContext = (AppDbContext?)scope.ServiceProvider.GetService<IAppDbContext>();
                    dbContext!.Database.Migrate();
                    DbSeeder.DoSeeding(dbContext);
                }
                catch (Exception ex)
                {
                    ILogger<Program> logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database");
                }
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}