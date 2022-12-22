class Program
{
    static void Main(string[] args)
    {
        // 1

        Console.WriteLine("Enter positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sumResult = 0;

        for (int i = 0; i <= number; i++)
        {
            sumResult += i;
        }

        Console.WriteLine($"Result: {sumResult}");

        // 2

        Console.WriteLine("Multiplication table for the number 3: ");
        int num = 3;
        int multiplier = 1;
        while (multiplier <= 10)
        {
            int multResult = num * multiplier;
            Console.WriteLine($"{num} * {multiplier} = {multResult}");
            multiplier++;
        }

        // 3

        int[] arrayToMultiply = { 3, 5, 9, 8, 15 };
        int multResult2 = 1;
        foreach (int i in arrayToMultiply)
        {
            multResult2 *= i;
        }
        Console.WriteLine($"Multiplication result of elements in array: {multResult2}\n");

        // 4

        int num2 = 2048;
        int divider = 2;
        int divResult = 0;
        while (num2 >= 10)
        {
            num2 /= divider;
            divResult++;
        }
        Console.WriteLine($"Number {num2} must be divided {divResult} times to make it less than 10\n");

        // 5

        string[] strings = { "Goodbye", "Good morning", "Viskas gerai", "Hello", "Labanakt" };
        foreach (string word in strings)
        {
            // Console.WriteLine(word);
            if (word == "Hello")
            {
                Console.WriteLine("Labas!\n");
                break;
            }
        }

        // 6

        int[] numbers = { 6, 2, 7, 8, 9, 13, 5, 3, 11, 72, 4 };
        sumResult = numbers[0] + numbers[numbers.Length - 1];
        Console.WriteLine($"Sum result of first and last elements of array: {sumResult}");

        // 7

        int maxIndex = 0;
        int minIndex = 0;
        int maxValue = numbers[0];
        int sumOfIndexes = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
                maxIndex = i;
            }
        }
        int minValue = maxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
                minIndex = i;
            }
        }
        sumOfIndexes = minIndex + maxIndex;
        Console.WriteLine($"Minimum element: {minValue}\nMaximim element: {maxValue}\nSum of indexes of these elements: {sumOfIndexes}");

        // 8

        int[] numsToSort = { 6, 2, 7, 0, 8, 9, 13, 5, 1, 16, 6, 2, 3, 7, 3, 2 };
        Console.WriteLine("\nArray before sort");
        foreach (int i in numsToSort)
        {
            Console.Write($"{i} ");
        }

        int swapped = 0;
        do
        {
            swapped = 0;
            for (int i = 0; i < numsToSort.Length - 1; i++)
            {
                if (numsToSort[i] > numsToSort[i + 1])
                {
                    int temp = numsToSort[i + 1];
                    numsToSort[i + 1] = numsToSort[i];
                    numsToSort[i] = temp;
                    swapped++;
                }
            }
        } while (swapped != 0);

        Console.WriteLine("\nArray after sort");
        foreach (int i in numsToSort)
        {
            Console.Write($"{i} ");
        }

        // 9

        Console.ReadKey();
        Console.Clear();
        int a = 0, b = 0;
        for (int i = 1; i <= 10; i++)
        {
            a = i;
            b = 1;
            Console.WriteLine($"Multiplication table for the number {a}: ");
            while (b <= 10)
            {
                int multResult = a * b;
                Console.WriteLine($"{a} * {b} = {multResult}");
                b++;
            }
        }

        // 10

        Console.ReadKey();
        Console.Clear();
        int[,] twoDimArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int i = 0; i < twoDimArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimArray.GetLength(1); j++)
            {
                Console.Write($"{twoDimArray[i, j]} ");
            }
            Console.Write('\n');
        }

        // 11

        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // add number 11 to end of the array
        int[] ary2 = new int[array.Length + 1];
        for (int i = 0; i < ary2.Length; i++)
        {
            if (i == ary2.Length - 1)
                ary2[i] = 11;
            else
                ary2[i] = array[i];
        }

        // add number -1 to the beginning of the array
        int[] ary3 = new int[ary2.Length + 1];
        for (int i = 0; i < ary3.Length; i++)
        {
            if (i == 0)
                ary3[i] = -1;
            else
                ary3[i] = ary2[i - 1];
        }

        // add number 12 to position 4
        int[] ary4 = new int[ary3.Length + 1];
        for (int i = 0; i < ary4.Length; i++)
        {
            if (i == 3)
                ary4[i] = 12;
            else if (i < 3)
                ary4[i] = ary3[i];
            else
                ary4[i] = ary3[i - 1];
        }

        // remove the first element of the array
        int[] ary5 = new int[ary4.Length - 1];
        for (int i = 0; i < ary5.Length; i++)
        {
            ary5[i] = ary4[i + 1];
        }

        int[] array2 = { 100, 200, 300 };
        int[] newArray = new int[ary5.Length + array2.Length];

        // creating an array from two arrays
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i < ary5.Length)
                newArray[i] = ary5[i];
            else
                newArray[i] = array2[i - ary5.Length];
        }

        Console.WriteLine("\n1st array after modifying:");
        foreach (int i in ary5)
            Console.Write($"{i} ");

        Console.WriteLine("\n2nd array:");
        foreach (int i in array2)
            Console.Write($"{i} ");

        Console.WriteLine("\n3rd array created from elements of 1st and 2nd arrays");
        foreach (int i in newArray)
            Console.Write($"{i} ");
    }
}