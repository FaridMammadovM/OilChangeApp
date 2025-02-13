using Application.CQRS.Queries.Notification.GetAllNotificationByCustomer.Dto;
using MediatR;

namespace Application.CQRS.Queries.Notification.GetAllNotificationByCustomer
{
    public class GetAllNotificationByCustomerQuery : IRequest<IList<GetAllNotificationByCustomerResDto>>
    {
        public GetAllNotificationByCustomerReqDto Request { get; set; }
    }
}
