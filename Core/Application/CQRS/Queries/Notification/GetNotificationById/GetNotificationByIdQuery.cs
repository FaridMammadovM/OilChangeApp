using Application.CQRS.Queries.Notification.GetNotificationById.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Notification.GetNotificationById
{
    public class GetNotificationByIdQuery : IRequest<GetNotificationByIdResDto>
    {
        public int NotificationId { get; set; }
    }
}
