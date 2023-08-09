using Microsoft.AspNetCore.Http;
using Plugins.DataStore.SQL.Infrastructure.Extensions;
using System.Security.Claims;

namespace Plugins.DataStore.SQL.Infrastructure.Services
{

    public class CurrentUserServiceDB : ICurrentUserServiceDB
    {
        private readonly ClaimsPrincipal user;

        public CurrentUserServiceDB(IHttpContextAccessor httpContextAccessor)
                => this.user = httpContextAccessor.HttpContext?.User;

        public string GetId()
            => user?.GetId();

        public string GetUserName()
        => user?.Identity?.Name;

    }
}
