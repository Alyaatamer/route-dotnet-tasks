using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class CacheServices(ICacheRepository cacheRepository) : ICacheServices
    {
        public async Task<string?> GetAsync(string Cachekey)
        {
            return await cacheRepository.GetAsync(Cachekey);
        }

        public async Task SetAsync(string Cachekey, object Cachevalue, TimeSpan TimeToLive)
        {
            var Value = JsonSerializer.Serialize(Cachevalue);
            await cacheRepository.SetAsync(Cachekey, Value, TimeToLive);
        }
    }
}
