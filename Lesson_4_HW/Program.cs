
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber(int number)
{
    int sum = 0;
    int numb = number;
    while (numb != 0)
    {
        sum = sum + (numb % 10);
        numb = numb / 10;
    }
    return sum;    
}

Console.WriteLine("Add number ");
int numb = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(numb);
Console.WriteLine(result);
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int AnotherNumber(int numb1, int numb2)
{
    int result = 1;
    int multiplier = numb1;
    int count = 1;
    while(count <= numb2)
    {
        result = result * numb1;
        count++;
    }
    return result;
}

Console.WriteLine("Add first number ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add second number ");
int numb2 = Convert.ToInt32(Console.ReadLine());

int result = AnotherNumber(numb1, numb2);
Console.WriteLine(result);
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;    
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < (array.Length - 1); i++)
        Console.Write(array[i] + ", ");

    Console.Write(array[array.Length - 1] + "]\n ");
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(m);
ShowArray(newArray);
*/




















