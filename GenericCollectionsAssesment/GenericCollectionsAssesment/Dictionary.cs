using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsAssesment
{
    internal class Dictionary
    {
        public static void Main2(string[] args)
        {
            Dictionary<string,int> Dic = new Dictionary<string,int>();
            Dic.Add("Stud1", 21);
            Dic.Add("Stud2", 22);
            Dic.Add("Stud3", 23);
            Dic.Add("Stud4", 24);
            Dic.Add("Stud5",25);

            foreach(var display in  Dic)
            {
                Console.WriteLine(string.Format("Key : {0}, Value : {1}",display.Key,display.Value));

            }

            Dic.Remove("Stud1");

            if(Dic.ContainsKey("Stud2"))
            {
                Dic["Stud2"]=30;
            }
            else
            {
                Console.WriteLine("Dic key not exits stud3");
            }

            foreach (var display in Dic)
            {
                Console.WriteLine(string.Format("Key : {0}, Value : {1}", display.Key, display.Value));

            }

            Console.WriteLine(Dic.Count());
        }
    }
}


/*Task: Create a program that uses a Dictionary<TKey, TValue> to store and manage a collection of key-value pairs.

1. Create a Dictionary<string, int> to store student names (key) and their ages (value).

2. Add five different students and their ages to the Dictionary<string, int>.

3. Display all key-value pairs in the dictionary.

4. Remove a student by name.

5. Update the age of a specific student.

6. Check if a student exists in the dictionary by name.

7. Display the total count of students in the dictionary.
*/
