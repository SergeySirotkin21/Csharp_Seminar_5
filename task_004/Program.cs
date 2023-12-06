
// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// 4 3 1 => 2 6
// 2 6 9 4 6
// 4 6 2

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
// Программа нахождения индексов наименьшего элемента массива
void FindMinIndexes(int[,] matrix, out int iIndex, out int jIndex)
{
    iIndex = 0;
    jIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[iIndex, jIndex])
            {
                iIndex = i;
                jIndex = j;
            }
        }
    }
}
// Программа удаления строки и стобца с наименьшим элементом
int[,] DeleteRowAndCol(int[,] matrix, int iMin, int jMin)
{
    // новая матрица меньшего размера
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0, x = 0; i < matrix.GetLength(0); i++)
    {
        if(i == iMin) continue; //с этой строкой дальше не работаем

        for (int j = 0, y = 0; j < matrix.GetLength(1); j++)
        {
            if(j == jMin) continue; //с этим элементом строки дальше не работаем

            newMatrix[x, y] = matrix[i,j];
            y++;
        }
        x++;
    }

    return newMatrix;
}
// решение задачи:
// создали и распечатали массив
int[,] oldMatrix = GenerateMatrix(5, 5, -5, 10);
PrintMatrix(oldMatrix);
// нашли и вывели индексы элемента с мин значением с разрывом между строками 
FindMinIndexes(oldMatrix, out int iMin, out int jMin);
System.Console.WriteLine();
System.Console.WriteLine(iMin + " " + jMin);
System.Console.WriteLine();
//создали и распечатали новую матрицу без строки и столбца с мин значением элемента
int[,] newmatrix = (DeleteRowAndCol(oldMatrix, iMin, jMin));
PrintMatrix(newmatrix);
