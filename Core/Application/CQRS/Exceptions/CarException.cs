using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions
{
    public class CarException : BaseException
    {
        public CarException()
: base("Şifrə yanlışdır!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
