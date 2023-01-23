

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int GetNumb(int numOfNumbers)
{
    int count = 0;
    for(int i = 0; i < numOfNumbers; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0)
        {
            count++;
        }
        
    }
    return count;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetNumb(number);
Console.WriteLine("Number of positive numbers is: " + result);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*

void PointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1*x) + b1;
    if(k1==k2)
    {
        Console.Write("ТОчек пересечения нет");
    }
    else
    {
        Console.WriteLine(x); 
        Console.WriteLine(y); 
    }
}

Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

PointOfIntersection(k1, b1, k2, b2);
*/