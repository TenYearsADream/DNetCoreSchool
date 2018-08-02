using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Service;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreApp2
{
    public class MyExceptionFilter : IExceptionFilter

    {
        private readonly ILogService _logService;

        public MyExceptionFilter(ILogService logService)
        {
            this._logService = logService;
        }
        public void OnException(ExceptionContext context)
        {
            _logService.AddLog("77");
            throw new NotImplementedException();
        }
    }
}
