// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

void InputMatrix(int[,]matrix)
{
for(int i=0; i<matrix.GetLength(0); i++)
    {
    for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,21);
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


void replaceMatrix (int [,] matrix)
{
int n = matrix.GetLength(0);
for (int i=0; i<matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[n-1, i];
        matrix[n-1, i] = temp;
    }
}




Console.Clear();
Console.Write("Введите размер двухмерного массива: ");
int[]size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0],size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);

replaceMatrix(matrix);
Console.WriteLine("Результат замены строк: ");
PrintMatrix(matrix);