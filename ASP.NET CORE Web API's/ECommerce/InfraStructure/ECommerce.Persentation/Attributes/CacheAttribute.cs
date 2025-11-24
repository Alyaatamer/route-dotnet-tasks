using ECommerce.Abstraction.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.Persentation.Attributes
{
    public class CacheAttribute(int DurationInSec = 90) : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string CacheKey = CreateCacheKey(context.HttpContext.Request);
            ICacheServices cacheServices = context.HttpContext.RequestServices.GetRequiredService<ICacheServices>();
            var CacheValue = await cacheServices.GetAsync(CacheKey);
            if (CacheValue != null)
            {
                context.Result = new ContentResult()
                {
                    Content = CacheValue,
                    ContentType = "application/json",
                    StatusCode = StatusCodes.Status200OK
                };
                return;
            }
            var ExecutedContext = await next.Invoke();
            if(ExecutedContext.Result is ObjectResult Result && Result.Value != null)
            {
                await cacheServices.SetAsync(CacheKey,Result.Value, TimeSpan.FromMinutes(DurationInSec));
            }

        }

        private string CreateCacheKey(HttpRequest request)
        {
            StringBuilder Key = new StringBuilder();
            Key.Append($"{request.Path}?");

            foreach (var (key, value) in request.Query.OrderBy(x => x.Key))
            {
                Key.Append($"{key}={value}&");
            }
            return Key.ToString();
        }
    }
}
