using NP.WKR.PortOrderBase;

var builder = Host.CreateApplicationBuilder(args);
var env = builder.Environment;

builder.Configuration
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", false, true);

// Clear ALL Base Provideres
builder.Logging.ClearProviders();
builder.Services.AddLogging(logBuilder =>
{
    logBuilder.AddJsonConsole();
    logBuilder.SetMinimumLevel(LogLevel.Information);
});

builder.Services.AddHostedService<GeographicPortWorker>();

var host = builder.Build();
host.Run();