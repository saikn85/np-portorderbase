using NP.WKR.PortOrderBase;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<GeographicPortWorker>();

var host = builder.Build();
host.Run();
