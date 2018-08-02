using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public  interface IUserService: IServiceSupport
    {
        int GetUserCount();
    }
}
