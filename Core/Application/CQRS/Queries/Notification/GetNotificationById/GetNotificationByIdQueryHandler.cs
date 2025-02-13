using Application.CQRS.Queries.Notification.GetNotificationById.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Notification.GetNotificationById
{
    public class GetNotificationByIdQueryHandler : IRequestHandler<GetNotificationByIdQuery, GetNotificationByIdResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetNotificationByIdQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetNotificationByIdResDto> Handle(GetNotificationByIdQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<NotificationHistory>().GetAsync(m => m.Id == request.NotificationId && m.IsDeleted == false);
            return _mapper.Map<GetNotificationByIdResDto, NotificationHistory>(model);
        }
    }
}
