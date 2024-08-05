namespace GenericCollectionsAssesment
{
    internal class Program
    {
        static void Main1(string[] args)
        {
           List<int> list = new List<int>();

            list.Add(7);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach( var item in list )
            {
                Console.WriteLine(item);
            }
            // removed third item in list
            list.RemoveAt(2);
            //Insert a integer at position second
            list.Insert(2, 6);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List Count: "+list.Count);
             // sorting the array
            list.Sort();
            Console.WriteLine("Sort the list in the ascending order");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}


/*Task: Create a program that uses a List<T> to store and manage a collection of integers.

1. Create a List<int> to store integer items.

2. Add five different integers to the List<int>.

3. Display all items in the List<int>.

4. Remove the third item from the List<int>.

5. Insert a new integer at the second position.

6. Display the total count of items in the List<int>.

7. Sort the list in ascending order and display the sorted list.
*/