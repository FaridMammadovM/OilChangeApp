namespace Application.CQRS.Exceptions
{
    public class ValidationException : Exception
    {
        public IEnumerable<string> Errors { get; }

        public ValidationException(string message) : base(message)
        {
            Errors = new List<string> { message };
        }

        public ValidationException(IEnumerable<string> errors) : base("Validasiya xətası baş verdi!")
        {
            Errors = errors;
        }
    }
}