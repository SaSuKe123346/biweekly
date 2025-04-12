using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4Ex2
{
    using System;

    class Person
    {
        public string Details; // Single field to store name and age

        public Person(string name, int age)
        {
            Details = $"Name: {name}, Age: {age}";
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Alex", 20);
            Console.WriteLine(person1.Details);
        }
    }

}