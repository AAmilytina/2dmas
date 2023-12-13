// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;

void InputMatrix (int[ , ]matrix)
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




void Prov (int a, int b, int[ , ]matrix)
{
for(int i=0; i<matrix.GetLength(0); i++)
    {
    for(int j=0; j<matrix.GetLength(1); j++)
        {
           if (a<matrix.GetLength(0) && b<matrix.GetLength(1))
           {
            int element = matrix[a,b];
            Console.WriteLine($"Элемент на позиции [{a},{b}] равен {element}");
           }
            else Console.WriteLine("Такого элемента в массиве нет.");
        }
        
    }
}

Console.Clear();
Console.Write("Введите размер двухмерного массива: ");
int[]size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0],size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);

Console.Write("Введите номер строки позиции элемента: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер колонки позиции элемента: ");
int b = int.Parse(Console.ReadLine()!);

Prov(a,b,matrix);




