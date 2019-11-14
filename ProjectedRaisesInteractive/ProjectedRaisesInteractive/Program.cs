using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PREDICTED_RATES = 1.04;
            double employeeSalary1;
            double employeeSalary2;
            double employeeSalary3;

            Console.WriteLine("What is employee 1's salary this year >>>");
            employeeSalary1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is employee 2's salary this year >>>");
            employeeSalary2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is employee 3's salary this year >>>");
            employeeSalary3 = Convert.ToDouble(Console.ReadLine());

            employeeSalary1 = employeeSalary1 * PREDICTED_RATES;
            employeeSalary2 = employeeSalary2 * PREDICTED_RATES;
            employeeSalary3 = employeeSalary3 * PREDICTED_RATES;

            Console.WriteLine("Employee 1 salary is {0}", employeeSalary1);
            Console.WriteLine("Employee 2 salary is {0}", employeeSalary2);
            Console.WriteLine("Employee 3 salary is {0}", employeeSalary3);
        }
    }
}
