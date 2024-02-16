using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateRevisionTopics
{
    internal class Calculation
    {
        public void Add(int n1, int n2)
        {
            int r = n1 + n2;
            Console.WriteLine(r);
        }
        public void Sub(int n1, int n2)
        {
            int r = n1 - n2;
            Console.WriteLine(r);
        }
        public void Mul(int n1, int n2)
        {
            int r = n1 * n2;
            Console.WriteLine(r);
        }
        public void Dic(int n1, int n2)
        {
            int r = n1 / n2;
            Console.WriteLine(r);
        }
    }
}
