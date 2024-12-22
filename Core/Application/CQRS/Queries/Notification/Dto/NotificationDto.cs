namespace Application.CQRS.Queries.Notification.Dto
{
    public sealed class NotificationDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Phone { get; set; }
        public string CarModel { get; set; }
        public string CarNumber { get; set; }
    }
}
