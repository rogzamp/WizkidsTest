using System;
using WizkidsTest.Tasks;

namespace WizkidsTest.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Task 1
                Console.WriteLine("Task 1. Write a method that determines if a string is a palindrome or not.");
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();
                bool isPalindrome = Task1.IsPalindrome(input);
                if (isPalindrome)
                {
                    Console.WriteLine("Input is palindrome. \n");
                }
                else
                {
                    Console.WriteLine("Input is not palindrome. \n");
                }

                //Task 2
                Console.WriteLine("2. Write a method that prints the numbers from 1 to 100, but for multiples of 3 print Foo, for multiples of 5 print Bar and for numbers that are multiples of both 3 and 5 print FooBar.");
                Console.WriteLine(Task2.PrintNumbers());

                //Task 3
                Console.WriteLine("3. Write a method that can find and replace valid email adresses in a string.");
                Console.WriteLine("Enter the email text:");
                string emailText = Console.ReadLine();
                Console.WriteLine("Enter the new email address:");
                string newEmailAddress = Console.ReadLine();
                Console.WriteLine(Task3.FindAndReplaceEmails(emailText, newEmailAddress));


            }
            catch (Exception)
            {
                Console.WriteLine("Oops, something went wrong :(");
            }



        }
    }
}
