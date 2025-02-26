using System.Text;
using System.Text.Json;
using Application.CQRS.Queries.Notification.Job.Dto;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.Notification.Job
{
    public sealed class NotificationQueryHandler : IRequestHandler<NotificationQuery, IList<NotificationDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HttpClient _httpClient;

        public NotificationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _httpClient = new HttpClient();
        }
        public async Task<IList<NotificationDto>> Handle(NotificationQuery request, CancellationToken cancellationToken)
        {
            var targetDate = DateTime.UtcNow.AddMonths(-request.Month).Date;

            string message = "";


            var oilChangesList = await _unitOfWork.GetReadRepository<OilChanges>().GetAllAsync(
               p => p.IsDeleted == false &&
                    p.ServiceId == 2 &&
                    p.ChangeDate.Date == targetDate,
               include: query => query
                   .Include(o => o.CustomersCarsMatrix)
                       .ThenInclude(ccm => ccm.Cars)
                   .Include(o => o.CustomersCarsMatrix)
                       .ThenInclude(ccm => ccm.Customers)
           );

            if (request.Month == 3)
            {
                message = $@" qeydiyyat nömrəli avtomobilinizin mühərrikinin yağ dəyişmə prosesindən 3 ay keçmişdir. MasterClass tərəfindən yağın səviyyəsini yoxlamağınız tövsiyyə olunur.";
            }
            else
            {
                message = $@" qeydiyyat nömrəli avtomobilinizin mühərrikinin yağ dəyişmə prosesindən 6 ay keçmiş və yağın istismar müddəti bitmişdir. Mühərrik yağının dəyişdirilməsi üçün MasterClass-a yaxınlaşa bilərsiz.";
            }


            var notificationDtoList = oilChangesList.Select(o => new NotificationDto
            {
                CustomerId = o.CustomersCarsMatrix.Customers.Id,
                Message = o.CustomersCarsMatrix.CarNumber + message,
                Token = o.CustomersCarsMatrix.Customers.NotificationToken,
                Title = "Master Class bildiriş: " + o.CustomersCarsMatrix.CarNumber,
            }).ToList();

            foreach (var notificationDto in notificationDtoList)
            {
                NotificationHistory notificationHistory = new NotificationHistory()
                {
                    Token = notificationDto.Token,
                    Message = notificationDto.Message,
                    CustomerId = notificationDto.CustomerId,
                    Title = notificationDto.Message,
                    InsertedBy = 1,
                    InsertedDate = DateTime.Now,
                    NotificationDate = DateTime.Now
                };

                await _unitOfWork.GetWriteRepository<NotificationHistory>().AddAsync(notificationHistory);
                await _unitOfWork.SaveAsync();

               if (!string.IsNullOrEmpty(notificationDto.Token))
                {
                    await SendExpoNotification(notificationDto.Token, notificationDto.Title, notificationDto.Message);
                }
            }

            return notificationDtoList;
        }

        private async Task SendExpoNotification(string token, string title, string body)
        {
            var payload = new
            {
                to = $"{token}",
                title = title,
                body = body
            };

            var jsonPayload = JsonSerializer.Serialize(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://exp.host/--/api/v2/push/send", content);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Expo push notification failed: {errorMessage}");
            }
        }
    }
}