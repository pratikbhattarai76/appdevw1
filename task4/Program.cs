int[] numbers = { 7, 3, 9, 1, 5 };

Array.Sort(numbers);

Array.Reverse(numbers);

Console.WriteLine("Array elements:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

int position = Array.IndexOf(numbers, 5);

Console.WriteLine($"Position of 5: {position}");