namespace Application.CQRS.Queries.Branch.Brancies.Dtos
{
    public sealed class GetBranchResDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

    }
}
