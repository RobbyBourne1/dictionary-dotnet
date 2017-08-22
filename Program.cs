using System;
using System.Collections.Generic;

namespace dictionary_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new Dictionary<string, int>();
            string name = "";
            string phoneNumberString = "";
            int phoneNumber;
            
            while (name == string.Empty)
            {
                Console.WriteLine("Please Enter a Name:");
                name = Console.ReadLine();
            }

            while (!Int32.TryParse(phoneNumberString, out phoneNumber))
            {
                Console.WriteLine($"Please Enter a Phone Number assciated with {name}: ");
                phoneNumberString = Console.ReadLine();
            }

            myDict.Add(name, phoneNumber);
                //             
                // var 
                // int phoneNumber;
                // if ()
                // {
                //     Console.WriteLine($"Please enter the Phone number assciated with {name}: ");
                //     phoneNumber = int.Parse(Console.ReadLine());
                // ;
                // }
        }
    }
}
