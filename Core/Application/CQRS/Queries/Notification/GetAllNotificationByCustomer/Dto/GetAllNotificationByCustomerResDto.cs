namespace Application.CQRS.Queries.Notification.GetAllNotificationByCustomer.Dto
{
    public class GetAllNotificationByCustomerResDto
    {
        public int Id { get; set; }
        public string? Token { get; set; }
        public int Title { get; set; }
    }
}
