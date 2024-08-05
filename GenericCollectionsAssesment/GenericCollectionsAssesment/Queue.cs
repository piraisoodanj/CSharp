using GenericCollectionsAssesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsAssesment
{
    internal class Queue
    {
        public static void Main3(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Create");
            queue.Enqueue("Update");
            queue.Enqueue("delete");
            queue.Enqueue("exit");
            queue.Enqueue("close");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
                          
            //queue.Dequeue();

           //Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Count());
        }
    }
}


/*Task: Create a program that uses a Queue<T> to manage a queue of tasks.

1. Create a Queue<string> to store a list of tasks.

2. Add five different tasks to the Queue<string>.

3. Display all tasks in the queue.

4. Dequeue the first task and display it.

5. Peek at the next task in the queue without dequeuing it.

6. Display the total count of tasks in the queue.*/