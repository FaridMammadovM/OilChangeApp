using Application;
using Application.Exceptions;
using Hangfire;
using Hangfire.MemoryStorage;
using Infrastructure;
using Microsoft.OpenApi.Models;
using OilMapper;
using Persistence;
using Serilog;
using WebApi.Loging;
using WebApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration) // Konfiqurasiya faylından oxumaq üçün
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Tüm kaynaklara izin verir
              .AllowAnyHeader()  // Tüm başlıklara izin verir
              .AllowAnyMethod(); // Tüm HTTP yöntemlerine izin verir (GET, POST, PUT, DELETE, vb.)
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // JWT Bearer Authentication için Swagger yapılandırması
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Lütfen Bearer token'ınızı girin.",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
var env = builder.Environment;


builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false) // Əsas konfiqurasiya faylı mütləq olmalıdır
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true) // **Burada "true" olmalıdır**
    .AddEnvironmentVariables(); // Ətraf mühit dəyişənlərini də oxuyur (əlavə et)

builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();


builder.Services.AddHangfire(config =>
{
    config.UseMemoryStorage(); // SQL Server olmadan işləyir
});
builder.Services.AddHangfireServer();

builder.Services.AddSingleton<IHangfireService, HangfireService>();

var app = builder.Build();

app.Lifetime.ApplicationStarted.Register(() =>
{
    using var scope = app.Services.CreateScope();
    var hangfireService = scope.ServiceProvider.GetRequiredService<IHangfireService>();

    var recurringJobManager = scope.ServiceProvider.GetRequiredService<IRecurringJobManager>();

    recurringJobManager.AddOrUpdate(
        "three-month-notification-job",
        () => hangfireService.ThreeMonth(),
        "0 17 * * *"
    );

    recurringJobManager.AddOrUpdate(
        "six-month-notification-job",
        () => hangfireService.SixMonth(),
        "0 18 * * *"
    );
});


// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseCors("AllowAll");
app.UseMiddleware<LoggingMiddleware>(); // Loglama middleware-i

app.UseHttpsRedirection();
app.ConfigureExceptionHandlingMiddleware();

app.UseAuthentication();
app.UseAuthorization();

app.UseHangfireDashboard("/hangfire"); // **Hangfire dashboard əlavə edildi**
app.MapHangfireDashboard();
app.MapControllers();

app.Run();
