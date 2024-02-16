using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateRevisionTopics
{
    public delegate void printDel();
   
       
    internal class Event
    { 
        public event printDel print;
        public void Show()
        {
            Console.WriteLine("This method is going to show you how to subscribe objects to an event");
            Console.WriteLine("This method will execute once the event has raised");
        }
        
        public void TestEvent()
        {
            Event testEvent = new Event();
            testEvent.print += new printDel(testEvent.Show);
            Console.WriteLine("Do you want to print if yes press p");
            string choice = Console.ReadLine().ToLower();
            if (choice == "p")
            {
                testEvent.print.Invoke();
            }
        }
    }
}
