using Application.Bases;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SendGrid.Helpers.Errors.Model;
namespace Application.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            int statusCode = GetStatusCode(exception);

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            var errors = new List<string> { exception.Message };

            var response = new
            {
                errors,
                statusCode
            };

            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }


        private static int GetStatusCode(Exception exception) =>
          exception switch
          {
              BaseException baseException => baseException.StatusCode, // Xüsusi Exception-lar üçün
              BadRequestException => StatusCodes.Status400BadRequest,
              NotFoundException => StatusCodes.Status404NotFound,
              ValidationException => StatusCodes.Status422UnprocessableEntity,
              _ => StatusCodes.Status500InternalServerError
          };
    }
}
