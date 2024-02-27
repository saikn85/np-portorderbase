using NP.WKR.PortOrderBase;

var builder = Host.CreateApplicationBuilder(args);

// Clear ALL Base Provideres
builder.Logging.ClearProviders();

builder.Services.AddHostedService<GeographicPortWorker>();

var host = builder.Build();
host.Run();
