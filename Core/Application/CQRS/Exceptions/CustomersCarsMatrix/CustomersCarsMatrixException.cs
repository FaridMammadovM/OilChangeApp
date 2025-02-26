using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions.CustomersCarsMatrix
{
    public class CustomersCarsMatrixException : BaseException
    {
        public CustomersCarsMatrixException()
: base("Qeyd edilən məlumatlar mövcuddur!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
