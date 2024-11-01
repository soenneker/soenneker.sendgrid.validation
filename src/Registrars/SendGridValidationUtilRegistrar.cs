using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.SendGrid.Client.Validation.Registrars;
using Soenneker.SendGrid.Validation.Abstract;

namespace Soenneker.SendGrid.Validation.Registrars;

/// <summary>
/// A .NET typesafe implementation of SendGrid's Validation API
/// </summary>
public static class SendGridValidationUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="ISendGridValidationUtil"/> as a singleton service. <para/>
    /// </summary>
    public static void AddSendGridValidationUtilAsSingleton(this IServiceCollection services)
    {
        services.AddSendGridValidationClientUtilAsSingleton();
        services.TryAddSingleton<ISendGridValidationUtil, SendGridValidationUtil>();
    }

    /// <summary>
    /// Adds <see cref="ISendGridValidationUtil"/> as a scoped service. <para/>
    /// </summary>
    public static void AddSendGridValidationUtilAsScoped(this IServiceCollection services)
    {
        services.AddSendGridValidationClientUtilAsSingleton();
        services.TryAddScoped<ISendGridValidationUtil, SendGridValidationUtil>();
    }
}
