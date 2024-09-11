// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Sum of numbers: " + Sum(numbers));
        Console.WriteLine("Largest number: " + FindLargest(numbers));
        Console.WriteLine("Generated string: " + GenerateNumberString(numbers));
        Console.WriteLine("Numbers concatenated together: " + ConcatenateNumbers(numbers));
    }

    static int Sum(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int FindLargest(List<int> numbers)
    {
        int largest = int.MinValue;
        foreach (var number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        return largest;
    }

    static string GenerateNumberString(List<int> numbers)
    {
        string result = "";
        for (int i = 0; i < numbers.Count; i++)
        {
            result += numbers[i].ToString() + ", ";
        }
        return result.TrimEnd(',', ' ');
    }

    static string ConcatenateNumbers(List<int> numbers)
    {
        string result = "";
        foreach (var number in numbers)
        {
            result += number.ToString();
        }
        return result;
    }
}
