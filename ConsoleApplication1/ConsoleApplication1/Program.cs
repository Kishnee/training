
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person anyPerson = new Person();

            anyPerson.FirstName = "Priyanka";
            anyPerson.LastName = "Beekharry";
            anyPerson.DateOfBirth = new DateTime(1992,05,13);
            Console.WriteLine(anyPerson.FirstName);
            Console.WriteLine(anyPerson.Age);
            Console.WriteLine(anyPerson.FullName);
            Console.WriteLine(anyPerson.ZodiacSign);
            Console.ReadKey();

        }
    }
}
