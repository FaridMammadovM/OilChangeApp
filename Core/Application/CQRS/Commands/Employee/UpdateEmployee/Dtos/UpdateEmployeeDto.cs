namespace Application.CQRS.Commands.Employee.UpdateEmployee.Dtos
{
    public sealed class UpdateEmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Description { get; set; }

    }
}
