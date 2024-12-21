namespace Application.CQRS.Queries.Customer.VerifyOtp.Dtos
{
    public class VerifyOtpReqDto
    {
        public string Phone { get; set; }
        public int OtpCode { get; set; }
    }
}
