/*Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает значение 
 этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет
*/
/*

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
//NewMatrix(matrix);
//PrintMatrix(matrix);
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
Console.Write("Введите позицию элемента:  ");
string? positionElement = Console.ReadLine();
positionElement = RemSpaces(positionElement);
int[] position = RemString(positionElement);

if (position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0)
{
    double result = array[position[0] - 1, position[1] - 1];
    Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого числа в массиве нет");

int[] RemString(string input)
{
    int countNum = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNum++;
    }

    int[] numbers = new int[countNum];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}

string RemSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output += input[i];
        }
    }
    return output;
}