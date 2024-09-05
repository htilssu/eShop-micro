using Payment.Services;

namespace Payment.Extensions;

public static class Extensions
{
    public static IServiceCollection AddPayment(this IServiceCollection services)
    {
        services.AddScoped<IPaymentService, PaypalService>();
        return services;
    }
}
