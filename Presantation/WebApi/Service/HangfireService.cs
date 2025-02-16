using Application.CQRS.Queries.Notification.Job;
using MediatR;

namespace WebApi.Service
{
    public class HangfireService : IHangfireService
    {
        private readonly IMediator _mediator;
        public HangfireService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task SixMonth()
        {
            try
            {
                await _mediator.Send(new NotificationQuery()
                {
                    Month = 6
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ThreeMonth()
        {
            try
            {
                await _mediator.Send(new NotificationQuery()
                {
                    Month = 3
                });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
