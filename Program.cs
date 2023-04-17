using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of names
            List<string> names = new List<string>() { "Seth", "Jose", "Lixmar", "Linda", "Val" };

            Console.WriteLine("Before calling the delegate Filter function using RemoveAll:");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            
            names.RemoveAll(iFilter);   //Call RemoveAll function which has a predicate deligate as a parameter

            Console.WriteLine("After calling the delegate filter function using RemoveAll:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Filter Method
            bool iFilter(string s)
            {
                //return whether string contains "i"
                // the contains method return s a bool which we will return as well
                return s.Contains("i");
            }

            Console.ReadKey();
        }
    }
}
