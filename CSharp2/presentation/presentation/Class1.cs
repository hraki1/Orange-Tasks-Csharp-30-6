using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Person
    {
        // constructor 
        //Person(string Name , int Age)
        //{
        //    name = Name;
        //    age = Age;
        //}

        string name = "mohaimen";
        int age = 22;
        public int id = 12;
        protected char gender = 'M';
        public void viewInfo()
        {
            Console.Write($"The person name is {name} and it`s age {age}");
        }
    }
}
