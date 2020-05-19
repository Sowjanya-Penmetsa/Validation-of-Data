using System;
using System.Collections.Generic;

namespace Validation_of_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 2;

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                persons.Add(person);

            }

            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.ReadLine();

        }
    }
    
}
