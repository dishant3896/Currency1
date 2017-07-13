using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");
            string amnt = Console.ReadLine();

            //char last=amnt[amnt.Length - 1];
            //int numericValue;

            if (char.IsDigit(amnt[amnt.Length - 1]))
            {
                Console.WriteLine(amnt.Remove(0, 1));
            }
            else
            {
                Console.WriteLine(amnt.Remove(amnt.Length - 1, 1));
            }
            Console.ReadLine();
        }
    }
}
