using System;
using System.Collections.Generic;

namespace dictionary_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            var myDict = new Dictionary<string, int>();
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
                    myDict.Add(name, phoneNumber);
                    Console.WriteLine(myDict[name]);
                    Console.WriteLine("Please Enter a Name:");
                    name = Console.ReadLine();
                }
            }
            // Problem 2

            var lookup = name;
            while (name == lookup)
            {
               Console.WriteLine($"LookUp {lookup}");
               lookup = Console.ReadLine();
               foreach (var item in myDict)
               {
                   if (item.Key == lookup)
                   {
                       Console.WriteLine(item.Key);
                       Console.WriteLine(item.Value);
                   }
               } 
            }
        }
    }
}
