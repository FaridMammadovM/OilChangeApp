namespace Application.CQRS.Queries.Notification.GetNotificationById.Dtos
{
    public class GetNotificationByIdResDto
    {
        public int Id { get; set; }
        public string? Token { get; set; }
        public string? Message { get; set; }
        public string? Title { get; set; }
        public DateTime? NotificationDate { get; set; }
    }
}
