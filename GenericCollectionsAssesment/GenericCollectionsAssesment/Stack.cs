using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsAssesment
{
    internal class Stack
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("BookTitle1");
            stack.Push("BookTitle2");
            stack.Push("BookTitle3");
            stack.Push("BookTitle4");
            stack.Push("BookTitle5");

           // stack.Pop();

            foreach(var item in stack)
            {
                Console.WriteLine(item);    
            }

            stack.Pop();

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Count());

        }
    }
}

/*Task: Create a program that uses a Stack<T> to manage a stack of books.

1. Create a Stack<string> to store book titles.

2. Add five different book titles to the Stack<string>.

3. Display all book titles in the stack.

4. Pop the top book from the stack and display it.

5. Peek at the top book in the stack without popping it.

6. Display the total count of books in the stack.
*/