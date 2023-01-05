// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int secondNumber(int number)
{
    int den = number % 100;
    int ed = den / 10;
    return ed;
}

Console.Write("Введите трехзначное число ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb / 1000 != 0 || numb / 100 == 0)
{
    Console.Write("Вы ввели неверное число. Введите трехзначное число");
    return;
}

int newNumber = secondNumber(numb);

Console.Write("Второе число " + newNumber);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int thirdNumber(int number)
{
    int ed = number % 10;
    return ed;
}

Console.Write("Введите число ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb / 100 == 0)
{
  Console.Write("Третьего числа нет ");
  return;
}

while (numb / 1000 != 0)
{
  numb = numb / 10;
}

int newNumber = thirdNumber(numb);

Console.Write("Третье число " + newNumber);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/* Console.Write("Введите число от 1 до 7 ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb <= 5)
{
    Console.Write("Это рабочий день ");
}
else if ((numb >= 6) && (numb <= 7))
{
    Console.Write("Это выходной день ");
}
else
{
    Console.Write("Вы ввели неверное число. Введите от 1 до 7 ");
}
*/














