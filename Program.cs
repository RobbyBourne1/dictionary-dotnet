using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            // Problem 2 - Lookup

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
            string s = "abcabcabcdefab c a oo ija ;a ;skmdals kn";
            Console.WriteLine(letterCount(s)['b'] == 4);
            Console.WriteLine(letterCount(s).ContainsKey('z') == false);
            Console.WriteLine(letterCount(s).ContainsKey(' ') == false);
        }

        //Part 3 (LetterCount Function) 
        public static Dictionary<char, int> letterCount(string s)
        {
            var lowCase = Regex.Replace(s, @"\s+", "");

            lowCase.ToLower().ToCharArray();
            var charDictionary = new Dictionary<char, int>();
            foreach (var item in lowCase)
            {
                int count = lowCase.Where(c => c == item).Count();
                if (charDictionary.ContainsKey(item) == false)
                {
                    charDictionary.Add(item, count);
                }
            }
            foreach (var item in charDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            return charDictionary;
        }
    }
}
