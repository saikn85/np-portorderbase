using Microsoft.Extensions.DependencyInjection;
using NP.WKR.PortOrderBase.Service.Interfaces;

namespace NP.WKR.PortOrderBase.Service;

/// <summary>
/// IoC Container
/// </summary>
public static class ServiceRegistration
{
    /// <summary>
    /// Extension for registering all services and dependencies.
    /// </summary>
    /// <param name="serviceCollection">Collection of Service Desciptors</param>
    /// <returns>Collection of Service Desciptors</returns>
    public static IServiceCollection AddPortOrderServices(this IServiceCollection serviceCollection)
    {
        // Reader Service
        serviceCollection.AddSingleton<IPortOrderReader, PortOrderReader>();

        return serviceCollection;
    }
}
