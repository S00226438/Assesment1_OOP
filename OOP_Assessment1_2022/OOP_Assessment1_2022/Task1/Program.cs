using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the year you were born (eg. 2022)");
            string yearBorn = Console.ReadLine();

            int BornIn =Convert.ToInt32(yearBorn);

            if (BornIn > 2004)
                Console.WriteLine("User Cannot Vote");
            else
                Console.WriteLine("User Can Vote");

            Console.ReadLine();
        }
    }
}
