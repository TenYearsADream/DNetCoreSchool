using System;
using System.Collections.Generic;
using System.Text;

namespace efcoreConsole3
{
    public class Book
    {
        public  long Id { get; set; }
        public  string Name { get; set; }
        public long AuthorId { get; set; }

        public  Author Author { get; set; }
    }
}
