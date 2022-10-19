using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 50000;
            double infation = 0.1;

            double newsalary = salary + (salary * infation);

            Console.WriteLine(newsalary);
            Console.ReadLine();
        }

    }
}
