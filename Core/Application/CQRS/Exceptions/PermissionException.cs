using Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Exceptions
{
    public class PermissionException : BaseException
    {
        public PermissionException()
      : base("Sizin icazəniz yoxdur!", StatusCodes.Status422UnprocessableEntity) { }
    }
}
