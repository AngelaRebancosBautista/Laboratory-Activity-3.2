using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> prices = new List<decimal>();
            Console.WriteLine("Enter item prices (type '-1' to finish):");

            while (true)

            {
                string input = Console.ReadLine();
                if (input == "-1")
                {
                    break;
                }
                if (decimal.TryParse(input, out decimal price) && price >= 0)
                {
                    prices.Add(price);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number or -1 to finish.");
                }
            }
            if (prices.Count > 0)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Total items: {prices.Count}");
                Console.WriteLine($"Average price: {prices.Average()}");
                Console.WriteLine($"Highest price: {prices.Max()}");
                Console.WriteLine($"Lowest price: {prices.Min()}");
            }
            else
            {
                Console.WriteLine("No prices were entered.");
            }
        }
    }
}
                
            
        

    


