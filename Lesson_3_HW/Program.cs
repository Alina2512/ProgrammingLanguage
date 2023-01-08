// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int BigData(int number)
{
    int tmp = number;
    int cnt = 0;
    while (tmp != 0)
    {
        cnt = cnt + 1;
        tmp = tmp / 10;
    }

    int newNumb = 0;
    for(int i = (cnt); i > 0; i--)
    {
        int numb = number % 10;
        newNumb = newNumb + numb * Convert.ToInt32(Math.Pow(10, i - 1));
        number = number / 10;
    }

    return newNumb;
}

Console.WriteLine("Add number ");
int number = Convert.ToInt32(Console.ReadLine());
int numb = BigData(number);

if (number == numb)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(int x1, int y1, int z1,
                int x2, int y2, int z2)
{
    int xSq = (x2 - x1) * (x2 - x1);
    int ySq = (y2 - y1) * (y2 - y1);
    int zSq = (z2 - z1) * (z2 - z1);
    return Math.Sqrt(xSq + ySq + zSq);
}

Console.Write("Введите координаты первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int n)
{
    int count = 1;
    Console.WriteLine("Кубы чисел: ");
    while (count <= n)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}
Console.WriteLine("Add number ");
int n = Convert.ToInt32(Console.ReadLine());
Cube (n);
*/

