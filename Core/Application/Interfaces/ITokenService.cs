using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(Customers user, IList<string> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
    }
}
