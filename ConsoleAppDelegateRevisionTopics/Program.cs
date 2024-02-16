using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateRevisionTopics
{
    internal class Program
    {
        //  [AS] delegate returntype delegateName(parameters)

        public delegate void CalDel(int num1,  int num2);
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();

            CalDel calDel = new CalDel(cal.Add);
            Console.WriteLine("One method to delegate");
            calDel(21, 32);

            calDel += new CalDel(cal.Sub);
            Console.WriteLine("Two method to delegate");
            calDel(21, 32);

            calDel += new CalDel(cal.Mul);
            Console.WriteLine("Three methods to delegate");
            calDel(21, 32);

            calDel += new CalDel(cal.Dic);
            Console.WriteLine("Four method to delegate");
            calDel(21, 32);

            // 2. Anonymous

            AnnonymusLambda annonymusLambda = new AnnonymusLambda();

            // 3 4 5 Action
            FuncActionPredicate funcActionPredicate = new FuncActionPredicate();

            //6
            Event e = new Event();
            e.TestEvent();

            Console.ReadLine();
        }
    }
}
