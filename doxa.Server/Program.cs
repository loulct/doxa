using doxa.Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.WithOrigins("https://localhost:7001", "http://localhost:5049")
          .AllowAnyHeader()
          .AllowAnyMethod()
          .AllowCredentials();
    });
});

var app = builder.Build();

app.UseCors("AllowBlazorClient");

app.MapHub<ChatHub>("/chathub");

app.Run();
