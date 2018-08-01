using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreApp1
{
    public class TestService
    {
        private readonly DateService _dateService;

        public TestService(DateService dateSvc)
        {
            this._dateService = dateSvc;
        }
        public string Hello()
        {
            return "Hello AspnetCore"+_dateService.GetDate();
        }
    }
}
