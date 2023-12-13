// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,]matrix)
{
for(int i=0; i<matrix.GetLength(0); i++)
    {
    for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix(int[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
        {
            for(int j=0; j<matrix.GetLength(1); j++)
            {
             Console.Write($"{matrix[i,j]} \t");
            }
         Console.WriteLine();
         }
}

int SumStrok(int[,]matrix, int i)
{
    int sumStrok = int matrix[i, 0];
    for (int  j=1; j<matrix.GetLength(1); j++)
    {
        sumStrok += matrix[i,j];
    }
    return sumStrok;
}

int minSum = 1;
int sum  = SumStrok (int[,]matrix, 0);
for (int i=1; i < matrix.GetLength(0);i++)
{
    if (sum<SumStrok(matrix,i))
    {
        sum = SumStrok(matrix,i);
        minSum = i+1;
    }
}




Console.Clear();
Console.Write("Введите размер двухмерного массива: ");
int[]size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0],size[1]];


InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Строка с наим суммой эл.: {minSum}");


