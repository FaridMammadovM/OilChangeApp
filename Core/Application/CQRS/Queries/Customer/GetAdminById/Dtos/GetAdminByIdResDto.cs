namespace Application.CQRS.Queries.Customer.GetAdminById.Dtos
{
    public sealed class GetAdminByIdResDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
    }
}
