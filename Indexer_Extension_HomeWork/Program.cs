using Indexer_Extension_HomeWork.Models;
using Indexer_Extension_HomeWork.NewFolder;
using System.Text.RegularExpressions;

namespace Indexer_Extension_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            //Console.WriteLine("Eded daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"IsPowOfTwo: {(num.IsPowOfTwo())}");
            //Console.WriteLine($"IsPrime: {(num.IsPrime())}");


            //Task 2

            Gallery gallery = new Gallery();

            Car a =new Car() 
            {
                Name="gh",
                color="red",
                ProductYear=5
            };
            gallery[0] = a;
            //2.1
            Console.WriteLine(gallery[0]+"\n\n");


            //2.2
            Console.WriteLine(gallery["grh"]);
            Console.WriteLine(gallery["gh"]);


        }
    }
}