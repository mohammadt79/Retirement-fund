using Microsoft.Extensions.Caching.Memory;
using Retirementfund_MVC.Models;
using System;

namespace Retirementfund_MVC.Services
{
    public class AuthTokenCache
    {
        private readonly IMemoryCache _cache;

        public AuthTokenCache(IMemoryCache cache)
            => _cache = cache;

        public void Set(Users dto,string token)
            => _cache.Set(token, dto, TimeSpan.FromMinutes(30));
        public Users Get(string token)
        => _cache.Get<Users>(token);

    }
}
