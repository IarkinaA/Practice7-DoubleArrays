// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите индекс строки");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбика");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 4];

for(int i=0; i<3; i++)
{
    for(int j=0; j<4; j++)
    {
        matrix[i,j]=new Random().Next(10);
       
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}

if (row < 3 && column < 4)
Console.WriteLine(matrix[row, column]);
else Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
