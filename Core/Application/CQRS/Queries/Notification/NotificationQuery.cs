using Application.CQRS.Queries.Notification.Dto;
using MediatR;

namespace Application.CQRS.Queries.Notification
{
    public class NotificationQuery : IRequest<IList<NotificationDto>>
    {
        public int Month { get; set; }
    }
}
