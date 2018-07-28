using System;

namespace EFCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                Person per = new Person
                {
                    Name = "王基龙",
                    Age = 28,
                    Gender = true
                };
                db.Persons.Add(per);
               
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var person in db.Persons)
                {
                    Console.WriteLine(" - {0}",person.Name );
                }
            }
        }
    }
}
