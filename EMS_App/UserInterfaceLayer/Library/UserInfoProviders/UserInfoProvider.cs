using System;
using System.Web;
using Microsoft.AspNet.Identity;

namespace UserInterfaceLayer.Library.UserInfoProviders
{
    public class UserInfoProvider : IUserInfoProvider
    {
        public Guid GetUserId()
        {
            Guid.TryParse(HttpContext.Current.User.Identity.GetUserId(), out var userGuid);

            return userGuid;
        }
    }
}