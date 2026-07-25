using decodificarJwt.Features.JwtDecoder.Services;

public static class ServiceExtension
{
    public static IServiceCollection AddJwtDecoderService(this IServiceCollection services)
    {
        services.AddScoped<IJwtDecoderService, JwtDecoderService>();
        return services;
    }
}