using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Tokens
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;
        private readonly string _secretKey;
        private readonly int _accessTokenExpiration;
        private readonly int _refreshTokenExpiration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
            _secretKey = _configuration["JwtSettings:SecretKey"];
            _accessTokenExpiration = int.Parse(_configuration["JwtSettings:AccessTokenExpiration"]);
            _refreshTokenExpiration = int.Parse(_configuration["JwtSettings:RefreshTokenExpiration"]);
        }

        public string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_accessTokenExpiration),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}

