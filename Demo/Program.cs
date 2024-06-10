namespace Demo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Stack allocation example
            int x = 10; // Primitive type, allocated on the stack

            // Heap allocation example
            Person person1 = new Person("Alice"); // Reference type, allocated on the heap
            Person person2 = new Person("Bob"); // Another reference type, allocated on the heap

            // Modify person1's name to show how the card table tracks changes
            person1.Name = "Alice Smith";

            // Create more objects to trigger garbage collection
            for (int i = 0; i < 100000; i++)
            {
                Person tempPerson = new Person("Temp" + i);
            }

            // Force garbage collection for demonstration purposes
            //GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of program");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        // Finalizer
        ~Person()
        {
            Console.WriteLine($"Finalizer called for {Name}");
        }
    }

}
