using Hangfire.Dashboard;

namespace WebApi.Service
{
    public class AllowAllAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            return true; // Hər kəsə icazə verir
        }
    }
}