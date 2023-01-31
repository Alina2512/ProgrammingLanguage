
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    } 
    Console.WriteLine();
}

void Sorted2dNumbers(int[,] array)
{
    int temp = 0;
    for(int m = 0; m < array.GetLength(0); m++)
    {
        for(int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                if(array[m,i] < array[m,j])
                {
                    temp = array[m,i];
                    array[m,i] = array[m,j];
                    array[m,j] = temp;
                }
            }
        }
    }
    
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Sorted2dNumbers(newArray);
Show2dArray(newArray);


// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(size);
//     return array;    
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write((array[i]) + " ");
//     Console.WriteLine();
// }

// void SortedNumbers(int[] array)
// {
//     int temp = 0;
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[i] < array[j])
//             {
//                 temp = array[i];
//                 array[i] = array[j];
//                 array[j] = temp;
//             }
//         }
//     }
// }

// Console.Write("Input a number of elements: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(m);
// ShowArray(newArray);
// SortedNumbers(newArray);
// ShowArray(newArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    } 
    Console.WriteLine();
}
int[] SumOfElements(int[,] array)
{
	int[] result = new int[array.GetLength(0)];
	for(int i = 0; i < array.GetLength(0); i++)
		for(int j = 0; j < array.GetLength(1); j++)
			result[i] = (result[i] + Convert.ToInt32(array[i, j]));
	return result;		
}
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine(array[i] + " ");
//     } 
//     Console.WriteLine();
// }

int MinElement(int[] array)
{
    int minPos = 0;
    for(int i=0; i < array.GetLength(0); i++)
    {
        if(array[i] < array[minPos])
        {
            minPos = i;
        }
    }
    return minPos;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[] newArray = SumOfElements(myArray);
// ShowArray(newArray);

int miniI = MinElement(newArray);
Console.WriteLine("Минимальная сумма элементов расположена на строке под номером № " + (miniI+1));
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    if(array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы ");
        return array1;
    }
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                newArray[i,j] += array1[i,k] * array2[k,j];
            }      
        }
    }
    return newArray;
}

int[,] firstArray = CreateRandom2dArray();
Show2dArray(firstArray);

int[,] secondArray = CreateRandom2dArray();
Show2dArray(secondArray);

Show2dArray(MatrixMultiplication(firstArray, secondArray));
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of heights: ");
    int heights = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rows, columns, heights];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < heights; k++)
            {
                array[i,j,k] = new Random().Next(10, 99 +1);
            }
        }
    }
    return array;
}
void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " (" + i + ", " + j + ", " + k + ") ");
            }
            Console.WriteLine();    
        }   
    } 
}

int[,,] newArray = CreateRandom3dArray();
Show3dArray(newArray);

*/