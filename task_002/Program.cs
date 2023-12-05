
// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9 2 6 9
// 4 6 2 4 3 1

int ReadInt(string text)// программа ввода чмсла
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// программа заполнения двумерного массива
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

// Программа замены первой и последней строки массива 
int[,] ChangeMatrix(int[,] matrix)
{ 
    int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            tempMatrix[i, j] = matrix[i, j];
            if (i == 0)
                tempMatrix[0, j] = matrix[matrix.GetLength(0)-1, j];
            if (i == matrix.GetLength(0)-1)
                tempMatrix[matrix.GetLength(0)-1, j] = matrix[0, j];
        }
    }
    return tempMatrix;
}


// Решение задачи
int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
//  Заполнение массива
int[,] matrix = GenerateMatrix(rows, cols, 1, 9);
// Вывод исходного массива
PrintMatrix(matrix);
// Замена первой и последней строки двумерного массива
int[,]newMatrix = ChangeMatrix(matrix);
// разрыв между массивами
System.Console.WriteLine();
// Вывод массива
PrintMatrix(newMatrix);
