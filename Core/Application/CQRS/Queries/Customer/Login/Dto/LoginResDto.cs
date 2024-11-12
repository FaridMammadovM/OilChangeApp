namespace Application.CQRS.Queries.Customer.Login.Dto
{
    public sealed class LoginResDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
