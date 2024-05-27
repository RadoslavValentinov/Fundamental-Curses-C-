using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
           // Input
            string Mybook = Console.ReadLine();
            string nextbook = Console.ReadLine();
            int count = 0;
          //Logic
            while (nextbook != "No More Books")
            {
                if (Mybook==nextbook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                nextbook = Console.ReadLine();
                count++;
            }
            // result
            if (nextbook== "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
           
        }
    }
}
