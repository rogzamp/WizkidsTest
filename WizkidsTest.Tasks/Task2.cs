using System;
using System.Collections.Generic;
using System.Text;

namespace WizkidsTest.Tasks
{
    public class Task2
    {
        /// <summary>
        /// Prints the numbers from 1 to 100, but for multiples of 3 print Foo, for multiples of 5 print Bar 
        /// and for numbers that are multiples of both 3 and 5 print FooBar.
        /// </summary>
        public static string PrintNumbers()
        {
            string message = string.Empty;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    message += "FooBar \n";
                }
                else if (i % 3 == 0)
                {
                    message += "Foo \n";
                }
                else if (i % 5 == 0)
                {
                    message += "Bar \n";
                }
                else
                {
                    message += i + "\n";
                }
            }

            return message;
        }
    }
}
