using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public class AdminUserService : IAdminUserService
    {
        private ILogService _iLogService;

        public AdminUserService(ILogService iLogService)
        {
            this._iLogService = iLogService;
        }
        public string GetUserPassWord(string userName)
        {
            _iLogService.AddLog("Nihao");
            return "777";
        }
    }
}
