
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNums(int num)
{
    Console.Write(num + ", ");
    if(num > 1) ShowNums(num - 1);
    if(num < 1) ShowNums(num + 1);
}
ShowNums(-9);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int GetSum(int num1, int num2)
{
    if(num1 == num2)
    {
        return num1;
    } 
    else if(num2 > num1)
    {
        return num1 + GetSum((num1 + 1), (num2));
    }
    else
    {
        return num1 + GetSum((num1 - 1), num2);
    }
}
Console.WriteLine(GetSum(15,1));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int GetAkr(int num1, int num2)
{
    if(num1 == 0) 
    {
        return (num2 + 1);
    } 
    else if(num1 > 0 && num2 == 0)
    {
        return GetAkr((num1 - 1), (1));
    }
    else 
    {
        return GetAkr((num1 - 1), GetAkr(num1, num2 - 1));
    }
}
Console.WriteLine(GetAkr(2,2));
