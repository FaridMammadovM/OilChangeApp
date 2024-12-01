using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;

namespace Application.Beheviors
{
    public static class OpenToken
    {
        public static int FindId(IHttpContextAccessor _httpContextAccessor)
        {
            var authorizationHeader = _httpContextAccessor.HttpContext.Request.Headers["Authorization"];
            var tokenHandler = new JwtSecurityTokenHandler();
            var decodedToken = tokenHandler.ReadJwtToken(authorizationHeader);

            var claims = decodedToken.Claims.ToDictionary(c => c.Type, c => c.Value);
            string v = claims["askeri"];
            return Convert.ToInt32(v);
        }
    }
}
