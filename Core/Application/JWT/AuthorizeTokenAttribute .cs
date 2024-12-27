using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Application.JWT
{
    public class AtributteAuthenticator : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new UnauthorizedObjectResult(new { success = false, message = "Token tapılmadı." });
                    return;
                }

                // Token'ı doğrulama işlemi
                var jwtHelper = (JwtHelper)context.HttpContext.RequestServices.GetService(typeof(JwtHelper));
                var claimsPrincipal = jwtHelper.ValidateToken(token);

                if (claimsPrincipal == null)
                {
                    context.Result = new UnauthorizedObjectResult(new { success = false, message = "Geçərsiz token." });
                    return;
                }

                // Token geçerliyse, aksiyona devam et
                base.OnActionExecuting(context);
            }
            catch (Exception)
            {

                context.Result = new UnauthorizedObjectResult(new { success = false, message = "Geçərsiz token." });
            }

        }
    }
}