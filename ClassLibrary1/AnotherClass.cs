using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AnotherClass
    {
        public static string stroka;
        public static void Method(Person person)
        {
            stroka = "Имя= "+person.Name +" Возраст = " +person.Age.ToString();
            Console.WriteLine(stroka);
        }
    }
}
