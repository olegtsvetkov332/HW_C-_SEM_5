//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

System.Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
while (num2 < 100)
{
    System.Console.Write("Введите начальное значение массива >= 100 !!!: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());
while (num3 > 999)
{
    System.Console.Write("Введите конечное значение массива <= 999 !!!: ");
    num3 = Convert.ToInt32(Console.ReadLine());
}

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

int EvenNumbers(int[] array)
{
    int Counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Counter++; ;
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
    System.Console.Write("] количество четных чисел в массиве равно -> ");
}


int[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
Console.WriteLine(EvenNumbers(RandomArray));