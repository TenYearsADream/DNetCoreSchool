using System;

namespace efcoreConsole2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (MyDbContext dbContext = new MyDbContext())
            {
                Person per = new Person();
                per.Name = "王基龙";
                per.Age = 12;
                per.Gender = true;
                dbContext.Persons.Add(per);
                dbContext.SaveChanges();
            }
            Console.WriteLine("ok");
            Console.ReadLine();
        }
    }
}
