//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

System.Console.Write("Введите длинну массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начальное значение массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конечное значение массива: ");
int num3 = Convert.ToInt32(Console.ReadLine());

double[] GenerateRandomArray(int Lenght, int MinValue, int MaxValue)
{
    double[] RandomArray = new double[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        RandomArray[i] = Math.Round(rand.Next(MinValue, MaxValue)+rand.NextDouble(), 2);
    }
    return RandomArray;
}

void PrintRandomArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}: ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("] разница между максимальным и минимальным элементами массива равна -> ");
}

double difference(double[] array)
{
    double max = array.Max();
    double min = array.Min();    
    double deff = 0;
    return deff = max - min;
}

double[] RandomArray = GenerateRandomArray(num1, num2, num3);
PrintRandomArray(RandomArray);
Console.WriteLine(difference(RandomArray));