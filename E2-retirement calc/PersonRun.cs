using System;

namespace Exam2
{
    class PersonRun
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Name, Followed by Enter.");
            Console.WriteLine("");
            Console.WriteLine("");
            Person n = new Person();
            n.PubName = Console.ReadLine();

            Console.Write("Please Enter Age, Followed by Enter.");
            Console.WriteLine("");
            Console.WriteLine("");
            n.PubAge = Convert.ToInt32(Console.ReadLine());

            n.YTK();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(n.PubName + " will work " + n.YearsToWorkPub + " years before retirement.");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
