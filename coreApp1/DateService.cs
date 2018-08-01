using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreApp1
{
    public class DateService
    {
        public string GetDate()
        {
            return DateTime.Now.ToLongDateString();
        }

    }
}
