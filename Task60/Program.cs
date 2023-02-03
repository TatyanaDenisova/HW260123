/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] generate2DArray(int x, int y, int z, int start, int finish)
{
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(start, finish + 1);
            }
        }
    }
    return array;
}
void printArray(int[,,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],1}({i},{j},{k}) \t");
                
            }
            Console.WriteLine();
        }
        
    }
}
int[,,] array = generate2DArray(2, 2, 2, 10, 99);
printArray(array);