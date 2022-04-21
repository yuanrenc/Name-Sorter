using System;
using System.Collections.Generic;

namespace name_sorter
{
    public class ListManager
    {
        // create a new list of Person. Each Person contains two arguements: firstname and lastname; 
        public static List<Person> LoadData(string fileName)
        {
            string[] names = System.IO.File.ReadAllLines(fileName);
            List<Person> output = new List<Person>();
            foreach (string name in names)
            {
                var splitedName = name.Split(' ');
                var length = splitedName.Length;
                var lastname = splitedName[length - 1];
                var firstname = string.Join(' ', splitedName, 0, length - 1);
                output.Add(new Person { FirstName = firstname, LastName = lastname });
            }
            return output;
        }
    }
}
