
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// onsole.WriteLine("Hello, World!");
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

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
// Программа нахождения строки с наиеньшей суммой элементов 
int ChangeMatrix(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i ++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            sumArray[i] += matrix[i, j];
        }
    }
    int minSum = sumArray[0];
    int minIndex = 0; 
    for (int i = 1; i< matrix.GetLength(0); i++)
    {
        if (sumArray[i] < minSum)
            {
                minSum = sumArray[i];
                minIndex = i;
            }
    }
    return minIndex;
}      
 
// Решение задачи
int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");

//  Заполнение массива
int[,] matrix = GenerateMatrix(rows, cols, 1, 9);

// Вывод массива
PrintMatrix(matrix);

// Нахождение строки с наименьшей суммой элементов
int minIndex = ChangeMatrix(matrix);
       
//  разделение соообщений
System.Console.WriteLine();

// Вывод сообщения
System.Console.WriteLine($" => строка c индексом {minIndex}");
