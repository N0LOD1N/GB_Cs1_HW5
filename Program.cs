int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }

    Console.WriteLine("Задан массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    return array;
}

Console.WriteLine("Задача 34--------------------");

int HowManyEven(int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) even++;
    }
    return even;
}

int[] array1 = RandomArray(new Random().Next(10, 20), 100, 1000);

Console.WriteLine($"Количество чётных чисел в данном массиве: {HowManyEven(array1)}");


Console.WriteLine("\nЗадача 36--------------------");

int SumOfOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] array2 = RandomArray(10, -100, 100);

Console.WriteLine($"Сумма чисел на нечётных позициях: {SumOfOddIndex(array2)}");

Console.WriteLine("\nЗадача 38--------------------");

double[] array3 = new double[10];

for (int i = 0; i < array3.Length; i++)
{
    array3[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(-100, 100);
}

Console.WriteLine("Задан массив:");
for (int i = 0; i < array3.Length; i++)
{
    Console.Write(array3[i]);
    if (i != array3.Length - 1) Console.Write(", ");
    else Console.WriteLine(".");
}

double min = array3[0];
double max = array3[0];
for (int i = 1; i < array3.Length; i++)
{
    if (array3[i] > max) max = array3[i];
    else if (array3[i] < min) min = array3[i];
}
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равна {max - min}");