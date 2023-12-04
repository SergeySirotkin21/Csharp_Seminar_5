
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

// Выбор размера массива
int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");

//  Заполнение массива
int[,] matrix = GenerateMatrix(rows, cols, 1, 9);
 
 // Ввод позиции элемента массива
int k = ReadInt("Введите номер строки массива: ");
int n = ReadInt("Введите номер столбца массива: ");
int i = k-1;
int j = n-1;
// Вывод  массива
PrintMatrix(matrix);

// Вывод результатов поиска 
if (i < rows && j < cols )
    System.Console.WriteLine($" ({i}, {j}) => {matrix[i, j]}");
else 
{
    System.Console.WriteLine($" ({i}, {j})  => Такого элемента нет");
}
