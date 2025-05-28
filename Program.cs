using Weave.Routes;
using Weave.Services;
using Weave.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Add services
builder.Services.AddScoped<IDataBreachService, DataBreachService>();
builder.Services.AddScoped<IInfoService, InfoService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapInfoRoutes();
app.MapDataBreachRoutes();

app.Run();
