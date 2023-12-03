
// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет
// 4 3 1 (1,2) => 9
// 2 6 9 

int ReadInt(string text)// программа ввода чмсла
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// программа заполнения двмерного массива
int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}
// Программа вывода на печать двумерного массива
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
// Программа нахождения элементов массива
void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
        }
    }
}

// ------------------------------------------
int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");

//  Заполнение массива
int[,] matrix = GenerateMatrix(rows, cols, -9, 9);

// Вывод массива
PrintMatrix(matrix);

// // Нахождение элементов массива с четными индексами и возведение их в квадрат
ChangeMatrix(matrix);

System.Console.WriteLine();

// // Вывод массива
PrintMatrix(matrix);
// // Программа нахождения суммы диагонали массива Задача 2
// int SumMainDiagonal(int[,] matrix)
// {
//     int sum = 0;

//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {
//         sum += matrix[i, i];
//     }

//     return sum;
// }
// // ------------------------------------------

// int rows = ReadInt("Введите количество строк массива: ");
// int cols = ReadInt("Введите количество столбцов массива: ");

// //  Заполнение массива
// int[,] matrix = GenerateMatrix(rows, cols, -9, 9);

// // Вывод массива
// PrintMatrix(matrix);

// System.Console.WriteLine(SumMainDiagonal(matrix));
// // Программа нахождения среднего арифметического Задача 3
// double[] FindAverageInRows(int[,] matrix)
// {
//     double[] averageArray = new double[matrix.GetLength(0)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             averageArray[i] += matrix[i, j];
//         }
//         averageArray[i] = Math.Round(averageArray[i] / matrix.GetLength(1), 3);
//     }

//     return averageArray;
// }

// void PrintArray(double[] array)
// {
//     Console.WriteLine("[ " + string.Join(" | ", array) + " ]");
// }

// // ------------------------------------------

// int rows = ReadInt("Введите количество строк массива: ");
// int cols = ReadInt("Введите количество столбцов массива: ");

// //  Заполнение массива
// int[,] matrix = GenerateMatrix(rows, cols, -9, 9);

// // Вывод массива
// PrintMatrix(matrix);

// double[] averageArray = FindAverageInRows(matrix);

// PrintArray(averageArray);
