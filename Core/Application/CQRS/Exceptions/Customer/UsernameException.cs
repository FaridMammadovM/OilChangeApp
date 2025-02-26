using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions.Customer
{
    public class UsernameException : BaseException
    {
        public UsernameException()
      : base("Username mövcuddur!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
