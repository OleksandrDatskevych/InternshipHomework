using System.Collections.Immutable;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        // 1
        List<int> numbers = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        var result = from i in numbers where i % 2 == 0 select i;

        foreach (var i in result)
        {
            Console.Write($"{i} ");
        }

        // 2
        Console.WriteLine();
        List<int> numbers2 = new() { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        var result2 = from i in numbers2 where i > 0 where i >= 1 && i <= 11 select i;
        Console.WriteLine();

        foreach (var i in result2)
        {
            Console.Write($"{i} ");
        }

        // 3
        Console.WriteLine();
        var result3 = from i in numbers2 select new { Number = i, SqrNo = i * i };
        //var result3 = (from i in numbers2 select i).ToDictionary(i => i, i => i * i);
        Console.WriteLine();

        foreach (var i in result3)
        {
            Console.WriteLine($"{{Number = {i.Number}, SqrNo = {i.SqrNo}}}");
            //Console.WriteLine($"{{Number = {i.Key}, SqrNo = {i.Value}}}");
        }

        // 4
        Console.WriteLine();
        List<int> numbers3 = new() { 1, 3, 8, 3, -2, -5, 8, -2, 3, 3, 1, -5, -5, -5, -5 };
        var result4 = from i in numbers3 group i by i into j select new { Number = j.Key, Count = j.Count() };

        foreach (var i in result4)
        {
            Console.WriteLine($"Number {i.Number} appears {i.Count} times");
        }

        // 5
        Console.WriteLine();
        List<string> cities = new()
        {
            "ROME",
            "LONDON",
            "NAIROBI",
            "CALIFORNIA",
            "ZURICH",
            "NEW DEHLI",
            "AMSTERDAM",
            "ABU DHABI",
            "PARIS"
        };
        var result5 = from i in cities where Regex.IsMatch(i, @"^A\w*M$") select i;
        //var result5 = from i in cities where i.StartsWith('A') && i.EndsWith('M') select i;

        foreach (var i in result5)
        {
            Console.WriteLine(i);
        }

        // 6
        Console.WriteLine();
        List<int> numbers4 = new() { 5, 7, 13, 24, 6, 9, 8, 7 };
        var recordsToDisplay = 3;
        var result6 = (from i in numbers4 orderby i descending select i).Take(recordsToDisplay);

        foreach (var i in result6)
        {
            Console.WriteLine(i);
        }

        // 7
        Console.WriteLine();
        var result7 = from i in cities orderby i.Length, i select i;

        foreach (var i in result7)
        {
            Console.WriteLine(i);
        }

        // 8
        Console.WriteLine();
        List<string> words = new() { "Bread", "Honey", "Bread", "Butter", "Honey", "Biscuit", "Butter" };
        var result8 = from i in words.Distinct() orderby i select i;

        foreach (var i in result8)
        {
            Console.WriteLine(i);
        }
    }
}