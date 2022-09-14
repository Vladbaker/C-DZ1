// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows, columns];

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайту двумерный массив размера m на n, каждый элемент в массиве находится по формуле Amn = m + n. Выведите полученный массив на  экран.

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows, columns];

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = i + j;
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайту двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double [rows, columns];

// for(int i = 0; i < rows; i++)
// {
//     for(int j = 0; j < columns; j++)
//     {
//          matrix[i, j] = new Random().Next(0, 10);
//         if(i % 2 == 0 && j% 2 == 0)
//         {
//             matrix[i, j]= Math.Pow(matrix[i, j], 2);
//         }
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайье двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с инндексами (0, 0); (1, 1); и т.д).

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int[,] matrix = new int [rows, columns];

// for(int i = 0; i < rows; i++)
// {
//     for(int j = 0; j < columns; j++)
//     {
//          matrix[i, j] = new Random().Next(0, 10);
//         if(i == j)
//         {
//             sum +=matrix[i, j]; 
//         }
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Сумма = {sum}");

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double [rows, columns];

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
         matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}