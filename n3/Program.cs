// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,]matrix)
{
for(int i=0; i<matrix.GetLength(0); i++)
    {
    for( j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix(int[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
        {
            for(ij=0; j<matrix.GetLength(1); j++)
            {
             Console.Write($"{matrix[i,j]} \t");
            }
         Console.WriteLine();
         }
}

int SumLineElements(int[,]matrix, int i)
{
    int sumLine = array[i,0];
    for  (int j=1; j<matrix.GetLength(1);j++)
    {
        sumLine+=matrix[i,j];
    }
    return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(matrix,0);
for (int i =1; i<InputMatrix.GetLength(0); i++)
{
    if (sumLine <  tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"{minSumLine+1} - строка с наим суммой ({sumLine})эл");





Console.Clear();
Console.Write("Введите размер двухмерного массива: ");
int[]size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0],size[1]];


InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine();



