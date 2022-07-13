int[] CreateArray(int min, int max)
{
    int[] array = new int[8];

    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < 8; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[] array = CreateArray(min, max);

ShowArray(array);