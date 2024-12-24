namespace Application.CQRS.Queries.Employee.GetEmployees.Dtos
{
    public sealed class GetEmployeesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
    }
}
