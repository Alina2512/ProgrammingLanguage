
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write((array[i]) + " ");

    Console.WriteLine();
}

int DivideOnTwo(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, 100, 999);
ShowArray(newArray);

int result = DivideOnTwo(newArray);
Console.WriteLine("Number of even numbers is " + result);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(size);

    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write((array[i]) + " ");

    Console.WriteLine();
}

int SumOfNumbers(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m);
ShowArray(newArray);

int result = SumOfNumbers(newArray);
Console.WriteLine("Sum of odd elements is " + result);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76
/*

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(size) + new Random().NextDouble();

    return array;    
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write((array[i]) + " ");

    Console.WriteLine();
}

double DifferenceNumbers(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
           max = array[i]; 
        }
        if (array[i] < min)
        {
             min = array[i];
        }
       
    }
    diff = max - min;
    return diff;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(m);
ShowArray(newArray);

double result = DifferenceNumbers(newArray);
Console.WriteLine($"Difference between numbers is + {Math.Round(result, 2)}");
*/
