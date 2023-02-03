/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColour(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHaedOfArray(int length)
{
    Console.Write(" \t");
    for (int i = 0; i < length; i++)
    {
        printInColour(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void printArray(int[,] array)
{
    printHaedOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColour(i + "|\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine("-----------------------------------------------");
}
int[,] myltiplyResult(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int y = 0; y < firstArray.GetLength(1); y++)
            {
                result[i, j] += firstArray[i, y] * secondArray[y, j];
            }
        }
    }
    return result;
}

int[,] firstArray = generate2DArray(2, 2, 0, 10);
int[,] secondArray = generate2DArray(2, 2, 0, 10);
printArray(firstArray);
printArray(secondArray);
int[,] result = myltiplyResult(firstArray, secondArray);
printArray(result);