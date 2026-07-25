namespace decodificarJwt.Features.JwtDecoder.Services;

public interface IJwtDecoderService
{
    /// <summary>
    /// Decodifica una sección específica de un JWT en formato Base64Url y lo devuelve formateado como JSON indentado.
    /// </summary>
    /// <param name="rawToken">TokenJWT completo.</param>
    /// <param name="partIndex">0 para Header, 1 para Payload.</param>
    /// <returns>Cadena JSON formateada o mensaje de error descriptivo.</returns>
    string ParseJwtPart(string? rawToken, int partIndex);
}
