using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class Program
    {
        //defining a delegate type called Filter Delegate that takes a
        //person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating use of a delegate already existing");
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

            Console.WriteLine("Now demonstrating the creation of a new delegate");

            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            Console.WriteLine("Here is the full list of people");

            foreach(Person person in people)
            {
                Console.WriteLine("{0}, Age {1}", person.Name, person.Age);
            }

            DisplayPeople("Adults:", people, isAdult);

            DisplayPeople("Kids:", people, isKid);

            DisplayPeople("Seniors:", people, isSenior);

            //Filter Method
            bool iFilter(string s)
            {
                //return whether string contains "i"
                // the contains method return s a bool which we will return as well
                return s.Contains("i");
            }

            bool isAdult(Person p)
            {
                return p.Age >= 18; //return adults
            }

            bool isKid(Person p)
            {
                return p.Age < 18; //return kids
            }

            bool isSenior(Person p)
            {
                return p.Age > 59; // return seniors
            }

            //Part 2 Creating own Delegate
            
            Console.ReadKey();
        }
        //a method to display the list of people that passes the filter condition (returns true) 
        //method will take a title to be displayed, the list of people and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }
    }
}
