using Application.CQRS.Queries.Notification.Job.Dto;
using MediatR;

namespace Application.CQRS.Queries.Notification.Job
{
    public class NotificationQuery : IRequest<IList<NotificationDto>>
    {
        public int Month { get; set; }
    }
}
