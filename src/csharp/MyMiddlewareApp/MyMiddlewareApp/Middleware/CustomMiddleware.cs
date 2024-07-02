namespace MyMiddlewareApp.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomMiddleware> _logger;

        // Constructor takes a RequestDelegate as a parameter
        public CustomMiddleware(RequestDelegate next, ILogger<CustomMiddleware> logger)
        {
            _next = next; // This represents the next middleware in the pipeline
            _logger = logger;
        }

        // InvokeAsync method processes the HTTP request
        public async Task InvokeAsync(HttpContext context)
        {
            // Code to execute before the next middleware
            _logger.LogInformation("Middleware executing before next...");

            // Calling the next middleware in the pipeline
            await _next(context);

            // Code to execute after the next middleware
            _logger.LogInformation("Middleware executing after next");
        }
    }
}