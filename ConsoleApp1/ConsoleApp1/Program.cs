using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taxes Tax Calculator
            double itemPrice;
            double total;
            const double TAX_RATE = 0.06;
            string itemPriceString;

            Console.Write("Enter the price of the an item >> ");
            itemPriceString = Console.ReadLine();

            itemPrice = Convert.ToDouble(itemPriceString);
            total = itemPrice * TAX_RATE;

            Console.WriteLine("With a tax rate of", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));
        }
    }

