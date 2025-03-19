int[] numbers = new int[] { 5, 3, 8, 4, 2 };

//5, 3, 8, 4, 2
//3, 5, 8, 4, 2
//3, 5, 4, 8, 2
//3, 5, 4, 2, 8
//3, 4, 5, 2, 8
//3, 4, 2, 5, 8
//3, 2, 4, 5, 8
//2, 3, 4, 5, 8

int temp;
Console.WriteLine("Initial array:");
PrintArray(numbers);

int test = numbers.Length - 1;
int test1 = numbers[numbers.Length - 1];


for (int i = 0; i < numbers.Length - 1; i++)
{
    Console.WriteLine($"Iteration {i + 1}");

    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        var current = numbers[j];
        var next = numbers[j + 1];

        if (current > next)
        {
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
    PrintArray(numbers);
}

Console.WriteLine("Sorted array: ");
PrintArray(numbers);

static void PrintArray(int[] array)
{
    foreach(int num in array)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}