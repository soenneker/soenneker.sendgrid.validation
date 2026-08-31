using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.SendGrid.Client.Validation.Registrars;
using Soenneker.SendGrid.Validation.Abstract;

namespace Soenneker.SendGrid.Validation.Registrars;

/// <summary>
/// Registers the SendGrid email-address validation client.
/// </summary>
public static class SendGridValidationUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="ISendGridValidationUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddSendGridValidationUtilAsSingleton(this IServiceCollection services)
    {
        services.AddSendGridValidationClientUtilAsSingleton();
        services.TryAddSingleton<ISendGridValidationUtil, SendGridValidationUtil>();
        return services;
    }

    /// <summary>
    /// Adds <see cref="ISendGridValidationUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddSendGridValidationUtilAsScoped(this IServiceCollection services)
    {
        services.AddSendGridValidationClientUtilAsSingleton();
        services.TryAddScoped<ISendGridValidationUtil, SendGridValidationUtil>();
        return services;
    }
}
