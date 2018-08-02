using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public class LogService : ILogService
    {
        public void AddLog(string msg)
        {
            Console.WriteLine("日志"+msg);
        }
    }
}
