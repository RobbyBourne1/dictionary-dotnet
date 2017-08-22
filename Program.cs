using System;

namespace dictionary_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Name:");
            var name = Console.ReadLine();
                while (name != string.Empty)
                {
                    Console.WriteLine($"Please Enter a Phone Number assciated with {name}: ");
                    var phoneNumber = Console.ReadLine();
                    if (phoneNumber == string.Empty)
                    {
                        Console.WriteLine($"Please enter the Phone number assciated with {name}: ");
                        phoneNumber = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"{name} and {phoneNumber}");
                        Console.WriteLine("Please Enter a Name:");
                        name = Console.ReadLine();
                    }
                }
            }
        }
    }
