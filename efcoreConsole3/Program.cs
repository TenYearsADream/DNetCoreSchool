using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace efcoreConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Mydbcontext ctx = new Mydbcontext())
            {
                var book = ctx.Books.Include(b=>b.Author).First();

                Console.WriteLine(book.Author.Name);
            }
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
