using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_lab4
{
    class person
    {
        //PRIVATE INSTANCE CLASS
        //PUBLIC PROPERTIES
        public string Name { get; set; }

        public int Age { get; set; }

        //CONSTRUCTOR(S)
        public person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        //PRIVATE METHOD
        //PUBLIC METHOD
        public void SaysHello()
        {
            Console.WriteLine($"{Name}say hello");
        }
    }
}
