using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            person jagjit = new person(name: "jagjit", age: 22);
            jagjit.SaysHello();
            Console.ReadLine();
        }
    }
}
