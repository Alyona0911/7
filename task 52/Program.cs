// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMeanOfColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0),1)}\t");
    }
}


void PrintArray(int [,] matr)
{
    for( int i= 0; i < matr.GetLength(0) ; i++)
    {
        for(int j = 0 ; j < matr.GetLength(1) ; j++)
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
ArithmeticMeanOfColumns(matrix) ;



           
