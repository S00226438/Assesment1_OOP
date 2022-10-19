using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golfClubPrice = 100;

            Console.WriteLine("Please enter your place of residence");
            Console.WriteLine("Sligo");
            Console.WriteLine("Ireland");
            Console.WriteLine("Europe");
            Console.WriteLine("Other");

            string Residence = Console.ReadLine();

            if(Residence == "Sligo")
                Console.WriteLine($"price is : {golfClubPrice * GetDiscount("Sligo")}");
            else if (Residence == "Ireland")
                Console.WriteLine($"price is : {golfClubPrice * GetDiscount("Ireland")}");
            else if (Residence == "Europe")
                Console.WriteLine($"price is : {golfClubPrice * GetDiscount("Europe")}");
            else if (Residence == "Other")
                Console.WriteLine($"price is : {golfClubPrice * GetDiscount("Other")}");


            Console.ReadLine();
        }

        static decimal GetDiscount(string Area)
        {
            decimal discount;
            Area = Console.ReadLine();

            switch (Area)
            {
                case "Sligo":
                    discount = 0.7m; // 30%
                    break;

                case "Ireland":
                    discount = 0.8m; // 20%
                    break;

                case "Eurpoe":
                    discount = 0.9m; // 10%
                    break;

                case "Other":
                    discount = 1m; // 0%
                    break;

                default:
                    discount = 1m;
                    break;

            }

            return discount;
        }
    }
}
