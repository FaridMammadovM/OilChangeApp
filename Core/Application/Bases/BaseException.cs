using Microsoft.AspNetCore.Http;

namespace Application.Bases
{
    public class BaseException : ApplicationException
    {

        public int StatusCode { get; }

        public BaseException(string message, int statusCode = StatusCodes.Status400BadRequest)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
