using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Консоль
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Vasiliy",20);
            ClassLibrary1.AnotherClass.Method(person);

            Console.ReadKey();
        }
    }
}
