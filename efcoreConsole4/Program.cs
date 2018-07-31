using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;

namespace efcoreConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MydbContext ctx = new MydbContext())
            {
                var user = ctx.Users.First();
                long userId = user.Id;
                var relactions = ctx.UserRoles.Include(e => e.Role)
                    .Where(r => r.UserId == userId);
                foreach (var relation in relactions)
                {
                    Console.WriteLine(relation.Role.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
