using System.Text;
using Serilog;

namespace WebApi.Loging
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // HTTP sorğusunu logla
            var requestLog = await FormatRequest(context.Request);
            Log.Information("HTTP Sorğusu: {Request}", requestLog);

            // Sorğu ardıcıllığını davam etdir və cavabı tut
            var originalBodyStream = context.Response.Body;
            using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            try
            {
                await _next(context); // Middleware zəncirini davam etdir
            }
            finally
            {
                // HTTP cavabını logla
                var responseLog = await FormatResponse(context.Response);
                Log.Information("HTTP Cavabı: {Response}", responseLog);

                // Cavabın orijinalını bərpa et
                await responseBody.CopyToAsync(originalBodyStream);
            }
        }
        private async Task<string> FormatRequest(HttpRequest request)
        {
            request.EnableBuffering();
            var body = "";

            if (request.ContentLength > 0 && request.Body != null)
            {
                using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
                {
                    body = await reader.ReadToEndAsync();
                    request.Body.Position = 0; // Stream mövqeyini sıfırlayın
                }
            }

            return $"Method: {request.Method}, Path: {request.Path}, QueryString: {request.QueryString}, Body: {body}";
        }

        private async Task<string> FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var text = await new StreamReader(response.Body).ReadToEndAsync();
            response.Body.Seek(0, SeekOrigin.Begin);

            return $"Status Code: {response.StatusCode}, Body: {text}";
        }
    }
}
