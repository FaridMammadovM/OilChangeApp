using Application.Bases;

namespace Application.CQRS.Exceptions
{
    public class CarException : BaseException
    {
        public CarException() : base("Maşın mövcuddur!") { }
    }
}
