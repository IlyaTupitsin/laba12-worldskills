using System;
using System.Text.RegularExpressions;

public class IpValidator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите ip:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        string ipPattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        foreach (string number in numbers)
        {
            if (Regex.IsMatch(number, ipPattern))
            {
                Console.WriteLine($"{number} - подходит под IPv4 адрес");
            }
            else
            { Console.WriteLine("не подходит под IPv4 адрес"); }

        }
        Console.ReadKey();
    }
}
