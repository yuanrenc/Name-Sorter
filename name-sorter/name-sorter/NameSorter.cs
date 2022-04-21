using System;

namespace name_sorter
{
    using System.Collections.Generic;
    using System.Linq;

    class NameSorter
    {

        public static void Main(string[] args)
        {
            // get the data from target file;
            List<Person> people = ListManager.LoadData(args[0]);
            // sort the list: sort by lastname then firstname;
            people = people.OrderBy(x => x.LastName).ThenBy(x=>x.FirstName).ToList();
            // output the result; 
            List<string> names = new List<string> {};
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
                names.Add(person.FirstName + " " + person.LastName);
            }
            System.IO.File.WriteAllLines(@"sorted-names-list.txt",names);
            Console.ReadLine();
        }
    }
}
