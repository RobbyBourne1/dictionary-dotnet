using System;
using System.Collections.Generic;

namespace dictionary_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Please Enter a Name:");
            var name = Console.ReadLine();
            while (name != string.Empty)
            {
                Console.WriteLine($"Please Enter a Phone Number assciated with {name}: ");
                var phoneNumberString = Console.ReadLine();
                int phoneNumber;
                bool realNumber = Int32.TryParse(phoneNumberString, out phoneNumber);
                if (phoneNumber == 0)
                {
                    realNumber = Int32.TryParse(phoneNumberString, out phoneNumber);
                }
                else
                {
                    Console.WriteLine($"{name} and {phoneNumber}");
                    Console.WriteLine("Please Enter a Name:");
                    name = Console.ReadLine();
                }
            }

            // Problem 2

        }
    }
}
