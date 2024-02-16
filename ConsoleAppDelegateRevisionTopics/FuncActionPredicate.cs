using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateRevisionTopics
{
    internal class FuncActionPredicate
    {
        public FuncActionPredicate() 
        {
            //3.
            Action<string, string> printFullName = (fn, ln) =>
            {
                Console.WriteLine("Full Name " + fn + ln);
            };
            Console.WriteLine("Fname");
            string fName = Console.ReadLine();
            Console.WriteLine("Lname");
            string lName = Console.ReadLine();
            printFullName(fName, lName);

            //4.
            Func<double, double, double> multi = (a, d) => a * d;
            Console.WriteLine("a");
            double fNum =double.Parse(Console.ReadLine());
            Console.WriteLine("d");
            double lNum = double.Parse(Console.ReadLine());
            double r = multi(fNum, lNum);
            Console.WriteLine("Result " + r);

            // 5.
            Predicate<int> isEven = (number) => { return number % 2 == 0; };
            Console.WriteLine("Enter Num to find odd or even");
            int num = int.Parse(Console.ReadLine());
            if(isEven(num))
            {
                Console.WriteLine("is even num");
            }
            else
            {
                Console.WriteLine("is odd num");
            }
        }
    }
}
