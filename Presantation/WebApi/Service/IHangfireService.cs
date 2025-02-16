namespace WebApi.Service
{
    public interface IHangfireService
    {
        public Task ThreeMonth();
        public Task SixMonth();
    }
}
