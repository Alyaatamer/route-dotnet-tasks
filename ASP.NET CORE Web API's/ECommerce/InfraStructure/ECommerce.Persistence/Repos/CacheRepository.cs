using ECommerce.Domain.Contracts.Repos;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistence.Repos
{
    public class CacheRepository(IConnectionMultiplexer connection) : ICacheRepository
    {
        private IDatabase database = connection.GetDatabase();
        public async Task<string?> GetAsync(string Cachekey)
        {
            var Cachevalue = await database.StringGetAsync(Cachekey);

            return Cachevalue.IsNullOrEmpty ? null : Cachevalue.ToString();
        }

        public async Task SetAsync(string Cachekey, string Cachevalue, TimeSpan TimeToLive)
        {
            await database.StringSetAsync(Cachekey, Cachevalue, TimeToLive);
        }
    }
}
