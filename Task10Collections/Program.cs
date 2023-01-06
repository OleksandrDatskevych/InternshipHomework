using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using Task10Collections;

internal class Program
{
    static void Main(string[] args)
    {
        // LIST
        List<int> list = new() { 1, 6, 2, 4, 6, 2, 4, 7, 1, 7, 2, 62, 26, 13, 4, 62, 34, 52, 78, 234, 62, 23 };
        Console.WriteLine(SumOfEven(list));
        List<string> words = new() { "Viskas", "Gerai", "Labanakt", "Kariotiškės", "Pasivaikščioti", "Ačiū", "Sveiki", "Dėkoju", "Labas" };
        FilterWords(words);
        // LINKED LIST
        LinkedList<int> list2 = new(list);
        var item1 = 4;
        var item2 = 10;
        AddItemsToLinkedList(list2, item1, item2);

        var node = list2.First;

        while (node != null)
        {
            Console.Write($"{node.Value} ");
            node = node.Next;
        }

        List<int> listToMerge1 = new() { 1, 3, 4, 7, 12 };
        List<int> listToMerge2 = new() { 1, 5, 7, 9 };
        LinkedList<int> mergedList = MergeTwoLists(listToMerge1, listToMerge2);
        node = mergedList.First;

        while (node != null)
        {
            Console.Write($"{node.Value} ");
            node = node.Next;
        }

        // QUEUE & STACK
        Queue<int> queue = FillQueue(5);
        var max = GetMaxValue(queue);
        Console.WriteLine($"Max value: {max}");
        DeleteMaxValue(ref queue);
        max = GetMaxValue(queue);
        Console.WriteLine($"Max value: {max}");
        max = GetMaxValue(queue);
        Console.WriteLine($"Max value: {max}");
        ReverseWord();

        // DICTIONARY
        Dictionary<string, int> map = new();
        map.Add("Oleksandr", 27);
        map["Serhii"] = 54;
        Console.WriteLine($"{map["Oleksandr"]}");
        List<int> numbers = new() { 1, 7, 5, 15, 76, 3, 4, 2, 6, 9 };
        List<string> strings = new()
        {
            "Viskas",
            "Gerai",
            "Labanakt",
            "Pasivaikščioti",
            "Ačiū",
            "Sveiki",
            "Dėkoju",
            "Labas",
            "Einu",
            "Važiuoti"
        };
        Dictionary<int, string> mergedMap = SortMergeLists(numbers, strings);

        foreach (var pair in mergedMap)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        Dictionary<string, City> mapCity = new()
        {
            { "Kherson", new City(289, 135.7) },
            { "Kyiv", new City(2884, 839) },
            { "Dnipro", new City(966, 409.7) },
            { "Lviv", new City(721, 149) },
            { "Kharkiv", new City(1419, 350) }
        };

        Console.WriteLine("Sort by area");
        var orderByArea = (from city in mapCity orderby city.Value.Area select city).ToList();

        foreach (var city in orderByArea)
        {
            Console.WriteLine($"{city.Key}: Population: {city.Value.Population}, Area: {city.Value.Area}");
        }

        Console.WriteLine("\nSort by population, descending");
        var orderByPopulation = (from city in mapCity orderby city.Value.Population descending select city).ToList();

        foreach (var city in orderByPopulation)
        {
            Console.WriteLine($"{city.Key}: Population: {city.Value.Population}, Area: {city.Value.Area}");
        }

        var totalPopulation = 0;
        var cityPop = from city in mapCity select city.Value.Population;

        foreach (var pop in cityPop)
        {
            totalPopulation += pop;
        }

        Console.WriteLine($"\nTotal population: {totalPopulation}");
    }

    static int SumOfEven(List<int> list)
    {
        var sum = 0;

        foreach(var i in list)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }

    static void FilterWords(List<string> list)
    {
        Console.WriteLine("Enter lenght of word: ");
        var len = int.Parse(Console.ReadLine());

        foreach(var word in list)
        {
            if (word.Length == len)
            {
                Console.WriteLine(word);
            }
        }
    }

    static void AddItemsToLinkedList(LinkedList<int> linkedList, int item1, int item2)
    {
        var node = linkedList.First;

        while (node is not null)
        {
            if (node.Value == item1)
            {
                linkedList.AddAfter(node, item2);
            }
            node = node.Next;
        }
    }

    static LinkedList<int> MergeTwoLists(List<int> list1, List<int> list2)
    {
        LinkedList<int> result = new();

        foreach(var i in list1)
        {
            if (list2.Contains(i))
            {
                result.AddLast(i);
            }
        }

        return result;
    }

    static Queue<int> FillQueue(int capacity)
    {
        Queue<int> queue = new();

        while (queue.Count < capacity)
        {
            Console.WriteLine("Enter number to enqueue:");
            var number = int.Parse(Console.ReadLine());
            queue.Enqueue(number);
        }

        return queue;
    }

    static int GetMaxValue(Queue<int> queue)
    {
        var max = queue.Peek();

        foreach(var item in queue)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }

    static void DeleteMaxValue(ref Queue<int> queue)
    {
        var max = GetMaxValue(queue);
        Queue<int> newQueue = new();

        while (queue.Count > 0)
        {
            if (queue.Peek() == max)
            {
                queue.Dequeue();
            }
            else
            {
                newQueue.Enqueue(queue.Dequeue());
            }
        }

        queue = new Queue<int>(newQueue);
    }

    static void ReverseWord()
    {
        Stack<char> stack = new();
        string? word;

        do
        {
            Console.WriteLine("Enter 3 letter word:");
            word = Console.ReadLine() ?? throw new ArgumentNullException();
        } while (word.Length != 3 || word == string.Empty || word is null);

        foreach (char ch in word)
        {
            stack.Push(ch);
        }

        var newWord = string.Empty;

        while(stack.Count > 0)
        {
            newWord += stack.Pop();
        }

        Console.WriteLine(newWord);
    }

    static Dictionary<int,string> SortMergeLists(List<int> keys, List<string> values)
    {
        Dictionary<int, string> mergedMap = new();
        var keysSorted = (from key in keys orderby key select key).ToList();
        var valuesSorted = (from value in values orderby value descending select value).ToList();

        for (var i = 0; i < keys.Count; i++)
        {
            mergedMap[keysSorted[i]] = valuesSorted[i];
        }

        return mergedMap;
    }
}
