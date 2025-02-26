using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions
{
    public class ProductException : BaseException
    {
        public ProductException()
           : base("Məhsul mövcuddur!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
