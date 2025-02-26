using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions.Customer
{
    public class CustomerFindPhoneException : BaseException
    {
        public CustomerFindPhoneException()
      : base("Telefon nömrəsi mövcuddur!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
