// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void PositionElement(int[,] matrix, int row, int column)
{
    if (row <= matrix.GetLength(0) && column <= matrix.GetLength(1))
    {
        Console.WriteLine($"{matrix[row, column]} ");
    }
    else
    {
        Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int [,] matr)
{
// i будет щелкать строки , j - столбцы
    for( int i= 0; i < matr.GetLength(0) ; i++)
    // matrix.GetLength(0) -( Выдаст нам 3 строки) ,данная команда возвращает колличество строк 
    {
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
        // matrix.GetLength(1) - (Выдаст 4 столбика ) ,данная команда возвращает колличество столбиков
        {
            Console.Write($"{matr[i,j]} ") ;
        }   
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for( int i= 0; i < matr.GetLength(0) ; i++)
    {
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
        {
            matr [i,j] = new Random().Next(1,10) ;
        }   
        Console.WriteLine();
    }
}

int [,] matrix = new int [3,4] ;
FillArray (matrix);
PrintArray(matrix) ;
Console.WriteLine();
int row = GetInput("Введите номер строки: ");
int column = GetInput("Введите номер столбца : ");
PositionElement(matrix, row, column);

