using ECommerce.Shared.ErrorModels;

namespace ECommerce.Middleware
{
    public class CutomExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<CutomExceptionMiddleware> logger;

        public CutomExceptionMiddleware(RequestDelegate Next , ILogger<CutomExceptionMiddleware> logger)
        {
            next = Next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);

                #region Header Response

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";

                #endregion

                #region Response Body

                var response = new ErrorToReturn()
                {
                    StatusCode = context.Response.StatusCode,
                    Message = e.Message,
                };

                await context.Response.WriteAsJsonAsync(response);

                #endregion
            }
        }
    }
}
