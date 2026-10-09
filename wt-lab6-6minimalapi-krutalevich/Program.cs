var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

// Блок 1, уровень 2: проверка запуска
app.MapGet("/", () => "Minimal API работает!");

// Блок 1, уровень 3: информация о приложении
app.MapGet("/api/info", () =>
{
    return new
    {
        Application = "Web Technologies",
        Technology = "ASP.NET Core Minimal API",
        Variant = "Авиакомпания",
        Version = "1.0"
    };
});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
//app.Run($"http://0.0.0.0:{port}");
app.Run();