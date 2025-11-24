using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Abstraction.IServices
{
    public interface ICacheServices
    {
        Task<string?> GetAsync(string Cachekey);
        Task SetAsync(string Cachekey, object Cachevalue, TimeSpan TimeToLive);
    }
}
