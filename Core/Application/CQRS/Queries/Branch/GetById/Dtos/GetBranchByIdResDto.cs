namespace Application.CQRS.Queries.Branch.GetById.Dtos
{
    public sealed class GetBranchByIdResDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<string> Phones { get; set; }

    }

}
