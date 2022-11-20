// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4];
double sum = 0;
double mean = 0;

for(int i=0; i<3; i++)
{
    for(int j=0; j<4; j++)
    {
        matrix[i,j]=new Random().Next(10);
       
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
 for(int j=0; j<4; j++)
{
   for(int i=0; i<3; i++)
   {
     sum+=matrix[i,j];
   }
   mean = sum / matrix.GetLength(0);
   Console.Write("{0:F1}; ", mean);

}
