/*Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];


Console.WriteLine();

void GetArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}
GetArray(array);

PrintArray(array);
int[,] NewArray = new int[m, n];
NewArray = TransformationArrayWhole(array);

PrintArrayInt(NewArray);

Console.WriteLine($"Cреднее арифметическое столюца: ");

for (int i = 0; i < n; i++)
{
    double avarage = 0;
    for (int j = 0; j < m; j++)
    {
        avarage += NewArray[j, i];
    }
    avarage = Math.Round(avarage / m, 1);
    Console.WriteLine($" № {i + 1} {avarage}");
}


int[,] TransformationArrayWhole(double[,] array)
{
    int[,] NewArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NewArray[i, j] = Convert.ToInt32(array[i, j]);
        }
    }
    return NewArray;
}

void PrintArrayInt(int[,] NewArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(NewArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}