namespace Application.CQRS.Queries.Customer.AdminLogin.Dtos
{
    public class AdminLoginResDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string Message { get; set; }
    }
}
