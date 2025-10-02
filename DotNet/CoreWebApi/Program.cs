using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using CoreWebApi;

var builder = WebApplication.CreateBuilder(args);

// 🔹 1️⃣ Configure Logging (Using Serilog for Structured Logging)
//builder.Host.UseSerilog((context, configuration) =>
//    configuration.ReadFrom.Configuration(context.Configuration));

//// 🔹 2️⃣ Load Configuration from appsettings.json & Environment Variables
//var configuration = builder.Configuration;

//// 🔹 3️⃣ Register Services (Dependency Injection)
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddScoped<IYourService, YourService>(); // Scoped Services
//builder.Services.AddSingleton<ISingletonService, SingletonService>(); // Singleton Services
//builder.Services.AddTransient<ITransientService, TransientService>(); // Transient Services

// 🔹 4️⃣ Add Controllers & Configure API Behavior
builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
    options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status401Unauthorized));
    options.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
});

// 🔹 5️⃣ Enable Swagger for API Documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 6️⃣ Enable CORS for Security (Allow Specific Origins)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("https://yourfrontend.com")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// 🔹 7️⃣ Add Authentication & Authorization
//builder.Services.AddAuthentication("Bearer")
//    .AddJwtBearer(options =>
//    {
//        options.Authority = "https://youridentityserver.com";
//        options.Audience = "yourapi";
//    });

builder.Services.AddAuthorization();

WebApplication app = builder.Build();

// 🔹 8️⃣ Configure Middleware (Request Pipeline)

// Enable Swagger in Development Only
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Global Exception Handling Middleware
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = "application/json";

        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
        if (exceptionHandlerPathFeature?.Error is not null)
        {
            var errorResponse = new { Message = "An unexpected error occurred." };
            await context.Response.WriteAsJsonAsync(errorResponse);
        }
    });
});

//app.UseMiddleware<WeatherForecast>();
app.UseHttpsRedirection(); // Force HTTPS
app.UseCors("AllowSpecificOrigin"); // Enable CORS
app.UseAuthentication(); // Enable Authentication
app.UseAuthorization(); // Enable Authorization
app.MapControllers(); // Map Controller Endpoints

app.Run();
