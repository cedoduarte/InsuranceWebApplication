using AutoMapper;
using InsuranceWebApplication.AutoMapperProfile;
using InsuranceWebApplication.CQRS.Cars.Validators;
using InsuranceWebApplication.CQRS.Insurances.Validators;
using InsuranceWebApplication.CQRS.Users.Validators;
using InsuranceWebApplication.Middlewares;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using InsuranceWebApplication.Services;
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
            builder.Services.AddMemoryCache();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<ICarService, CarService>();
            builder.Services.AddTransient<IInsuranceService, InsuranceService>();
            builder.Services.AddTransient<IVisitCountService, VisitCountService>();
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<ICarRepository, CarRepository>();
            builder.Services.AddTransient<IInsuranceRepository, InsuranceRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<ICreateUserCommandValidator, CreateUserCommandValidator>();
            builder.Services.AddTransient<IUpdateUserCommandValidator, UpdateUserCommandValidator>();
            builder.Services.AddTransient<ICreateCarCommandValidator, CreateCarCommandValidator>();
            builder.Services.AddTransient<IUpdateCarCommandValidator, UpdateCarCommandValidator>();
            builder.Services.AddTransient<ICreateInsuranceCommandValidator, CreateInsuranceCommandValidator>();
            builder.Services.AddTransient<IUpdateInsuranceCommandValidator, UpdateInsuranceCommandValidator>();
            builder.Services.AddTransient<IUserExcelFileService, UserExcelFileService>();
            builder.Services.AddTransient<ICarExcelFileService, CarExcelFileService>();

            builder.Services.AddSingleton(new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new MappingProfile());
            }).CreateMapper());

            builder.Services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
            });

            builder.Services.AddDbContext<IAppDbContext, AppDbContext>(options =>
            {
                string dbConnectionString = builder.Configuration.GetConnectionString(ConnectionStringName)!;
                options.UseSqlServer(dbConnectionString, dbOptions =>
                {
                    dbOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.GetName().Name);
                });
            });

            var app = builder.Build();
            app.UseCors(options =>
                options.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod());
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
            app.UseLogging("log.txt");
            app.UseAuthorization(builder.Configuration["AuthorizationToken"]!);
            app.MapControllers();
            app.Run();
        }
    }
}