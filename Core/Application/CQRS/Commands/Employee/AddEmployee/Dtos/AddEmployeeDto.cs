namespace Application.CQRS.Commands.Employee.AddEmployee.Dtos
{
    public sealed class AddEmployeeDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Description { get; set; }

    }
}
