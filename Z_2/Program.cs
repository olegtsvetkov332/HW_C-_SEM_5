//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

System.Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    int[] RandomArray = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = rand.Next(MinValue, MaxValue + 1);
    }
    return RandomArray;
}

int EvenNumbersPosition(int[] array)
{
    int Counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Counter += array[i];
        }
    }
    return Counter;
}

void PrintRandomArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("] сумма элементво на нечетных позициях в массиве равна -> ");
}

int[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
Console.WriteLine(EvenNumbersPosition(RandomArray));