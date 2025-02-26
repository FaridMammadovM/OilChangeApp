using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions.Customer
{
    public class PasswordException : BaseException
    {
        public PasswordException()
      : base("Şifrə yanlışdır!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
