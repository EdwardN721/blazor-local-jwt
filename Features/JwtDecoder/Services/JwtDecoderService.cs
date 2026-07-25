using System.Text;
using System.Text.Json;

namespace decodificarJwt.Features.JwtDecoder.Services;

public sealed class JwtDecoderService : IJwtDecoderService
{
    /// <inheritdoc/>
    public string ParseJwtPart(string? rawToken, int partIndex)
    {
        if (string.IsNullOrWhiteSpace(rawToken))
        {
            return "{ }";
        }

        string[]? parts = rawToken.Trim().Split('.');
        if (parts.Length <= partIndex)
        {
            return "/* Token inválido: falta la sección requerida */";
        }

        try
        {
            string jsonUnformatted = DecodeBase64Url(parts[partIndex]);
            return FormatJson(jsonUnformatted);
        }
        catch (Exception ex)
        {
            return $"/* Error al decodificar la sección del JWT: {ex.Message} */";
        }
    }

    #region Métodos privados

    private static string DecodeBase64Url(string base64Url)
    {
        string base64 = base64Url.Replace('_', '/').Replace('-', '+');

        switch (base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }

        byte[] bytes = Convert.FromBase64String(base64);
        return Encoding.UTF8.GetString(bytes);
    }

    private static string FormatJson(string jsonString)
    {
        using JsonDocument? jsonDocument = JsonDocument.Parse(jsonString);
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        return JsonSerializer.Serialize(jsonDocument, options);
    }

    #endregion
}
