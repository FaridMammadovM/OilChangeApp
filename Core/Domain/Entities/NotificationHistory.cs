using Domain.Common;

namespace Domain.Entities
{
    public class NotificationHistory : EntityBase
    {
        public string Token { get; set; }
        public string Message { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
    }
}
