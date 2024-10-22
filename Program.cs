using ArpineAmiryan;
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static bool Palindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Type the string");
        string input = Console.ReadLine().ToLower();
        bool result = Palindrome(input);
        Console.WriteLine(result);

        int[] array = { 12, 6, 4, 52, 0, 8 };
        foreach (var i in array)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();


        SortingAlgorithms.MergeSort(array, 0, array.Length - 1);
        foreach (var i in array)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();

    }
}
