using System;

namespace UserInterfaceLayer.Library.UserInfoProviders
{
    public interface IUserInfoProvider
    {
        Guid GetUserId();
    }
}