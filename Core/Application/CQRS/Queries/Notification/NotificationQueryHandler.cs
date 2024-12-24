using Application.CQRS.Queries.Notification.Dto;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.Notification
{
    public sealed class NotificationQueryHandler : IRequestHandler<NotificationQuery, IList<NotificationDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<NotificationDto>> Handle(NotificationQuery request, CancellationToken cancellationToken)
        {
            var targetDate = DateTime.UtcNow.AddMonths(-request.Month).Date;

            string message = "";
            

            var oilChangesList = await _unitOfWork.GetReadRepository<OilChanges>().GetAllAsync(
               p => p.IsDeleted == false &&
                    p.ServiceId == 1 &&
                    p.ChangeDate.Date == targetDate,
               include: query => query
                   .Include(o => o.CustomersCarsMatrix)
                       .ThenInclude(ccm => ccm.Cars)
                   .Include(o => o.CustomersCarsMatrix)
                       .ThenInclude(ccm => ccm.Customers)
           );

            if (request.Month == 3)
            {
                message = $@" qeydiyyat nömrəli avtomobilinizin mühərrikinin yağ dəyişmə prosesindən 3 ay keçmişdir.
                                 MasterClass tərəfindən yağın səviyyəsini yoxlamağınız tövsiyyə olunur.";
            }
            else
            {
                message = $@" qeydiyyat nömrəli avtomobilinizin mühərrikinin yağ dəyişmə prosesindən 6 ay keçmiş və yağın istismar müddəti bitmişdir. 
                              Mühərrik yağının dəyişdirilməsi üçün MasterClass-a yaxınlaşa bilərsiz.";
            }


            var notificationDtoList = oilChangesList.Select(o => new NotificationDto
            {
                CustomerId = o.CustomersCarsMatrix.Customers.Id,
                CustomerName = o.CustomersCarsMatrix.Customers.Name,
                CustomerSurname = o.CustomersCarsMatrix.Customers.Surname,
                Phone = o.CustomersCarsMatrix.Customers.Phone,
                CarModel = o.CustomersCarsMatrix.Cars.Model,
                CarNumber = o.CustomersCarsMatrix.CarNumber,
                Message = o.CustomersCarsMatrix.CarNumber + message
            }).ToList();



            return notificationDtoList;
        }
    }
}