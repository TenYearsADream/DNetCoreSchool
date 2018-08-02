using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public interface IAdminUserService: IServiceSupport
    {
        string GetUserPassWord(string userName);
    }
}
