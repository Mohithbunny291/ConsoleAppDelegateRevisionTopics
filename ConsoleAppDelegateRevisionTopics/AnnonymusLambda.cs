using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateRevisionTopics
{
    // 1,2 public delegate void WelDel(string name);

    public delegate double CalDel(double n1, double n2);

    internal class AnnonymusLambda
    {
        public AnnonymusLambda()
        {
            //1.
            // WelDel del = delegate (string name)
            //{
            //    Console.WriteLine("Hello in Anonymous method " + name);
            //};
            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();
            //del(userName);

            //2. 
            //WelDel del = (name) =>
            //{
            //    Console.WriteLine("Hello in Anonymous method " + name);
            //};
            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();
            //del(userName);

            //3. 
            CalDel del = (n1, n2) =>
            {
                return n1 + n2;
            };
            double fNum = 21.2;
            double sNum = 21.3;
            Console.WriteLine("sum of anonymus del"+del(fNum, sNum));
        }

    }
}
