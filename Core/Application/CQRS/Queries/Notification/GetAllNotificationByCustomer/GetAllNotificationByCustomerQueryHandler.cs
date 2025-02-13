using Application.CQRS.Queries.Notification.GetAllNotificationByCustomer.Dto;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Notification.GetAllNotificationByCustomer
{
    public class GetAllNotificationByCustomerQueryHandler : IRequestHandler<GetAllNotificationByCustomerQuery, IList<GetAllNotificationByCustomerResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllNotificationByCustomerQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllNotificationByCustomerResDto>> Handle(GetAllNotificationByCustomerQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<NotificationHistory>().GetAllAsync(m => m.IsDeleted == false && m.CustomerId == request.Request.CustomerId);

            return _mapper.Map<GetAllNotificationByCustomerResDto, NotificationHistory>(model);
        }
    }
}
