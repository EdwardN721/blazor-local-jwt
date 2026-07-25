using decodificarJwt.Core.Constants;
using decodificarJwt.Features.JwtDecoder.Services;
using Microsoft.AspNetCore.Components;

namespace decodificarJwt.Features.JwtDecoder;

public partial class JwtDecoder : ComponentBase
{
    // Usamos el atributo [Inject] en lugar de inyectarlo en el constructor
    [Inject]
    private IJwtDecoderService JwtService { get; set; } = default!;
    
    // Propiedad que se vincula al <textarea> en el archivo .razor
    public string RawToken { get; set; } = AppConstants.Jwt.DefaultDemoToken;

    // Propiedades de solo lectura que la vista consume
    // Al usar => se recalculan automáticamente cuando Blazor detecta un cambio en RawToken
    public string HeaderDecoded => JwtService.ParseJwtPart(RawToken, 0);
    public string PayloadDecoded => JwtService.ParseJwtPart(RawToken, 1);
}
