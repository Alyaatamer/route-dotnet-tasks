using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Contracts.Repos
{
    public interface ICacheRepository
    {
        Task<string?> GetAsync(string Cachekey);
        Task SetAsync(string Cachekey, string Cachevalue, TimeSpan TimeToLive);
    }
}
