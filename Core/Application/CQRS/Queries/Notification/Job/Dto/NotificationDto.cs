namespace Application.CQRS.Queries.Notification.Job.Dto
{
    public sealed class NotificationDto
    {
        public int CustomerId { get; set; }
        public string Message { get; set; }
        public string? Token { get; set; }
        public string Title { get; set; }

    }
}
