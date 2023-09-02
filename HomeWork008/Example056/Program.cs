// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

(int, int) GetArraySize()
{
    int rowSize = 0;
    int colSize = 0;
    string enteredSymbol = string.Empty;
    do
    {
        Console.Clear();
        Console.Write("Создать случайный 2D массив? Нажмите y/n: ");
        enteredSymbol = Console.ReadLine();
        if (enteredSymbol == "y")
        {
            rowSize = new Random().Next(2, 11);
            colSize = new Random().Next(2, 11);
            Console.WriteLine("Значение m: {0}", rowSize);
            Console.WriteLine("Значение n: {0}", colSize);
            Console.WriteLine();
            break;
        }
        else if (enteredSymbol == "n")
        {
            Console.Write("Введите значение m:");
            rowSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение n:");
            colSize = Convert.ToInt32(Console.ReadLine());
            break;
        }
    } while (true);

    return (rowSize, colSize);
}
void Fill2DArray(int[,] ArrayToFill, int deviation = 10)
{
    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
}
void Print2DArray(int[,] ArrayToPrint, int coloredRow = -1)
{
    Console.Write("[X]\t");
    for (int i = 0; i < ArrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t", i);
    }
    Console.WriteLine();
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        if (i == coloredRow)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        Console.Write($"[{i}]\t", i);
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            if (ArrayToPrint[i, j] < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write(ArrayToPrint[i, j] + "\t");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}
int GetRowSum(int[,] arrayToCalc, int rowNum)
{
    int rowSum = 0;
    for (int j = 0; j < arrayToCalc.GetLength(1); j++)
    {
        rowSum += arrayToCalc[rowNum, j];
    }
    return rowSum;
}
(int, int) GetNumberMinSumRow(int[,] arrayToSeek)
{
    int minSumRowNumber = 0;
    int minSum = -1, rowSum = -1;
    for (int i = 0; i < arrayToSeek.GetLength(0); i++)
    {
        rowSum = GetRowSum(arrayToSeek, i);
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowNumber = i;
        }
    }
    return (minSumRowNumber, minSum);
}

var (rowSize, colSize) = GetArraySize();
int[,] arrayToOperate = new int[rowSize, colSize];
Fill2DArray(arrayToOperate, deviation: 90);
var (numberRowMinSum, rowMinSum )= GetNumberMinSumRow(arrayToOperate);
Console.WriteLine("В сгенерированном массиве:");
Print2DArray(arrayToOperate, numberRowMinSum);
Console.WriteLine();
Console.WriteLine("Строка с индексом {0} имеет минимальную сумму = {1}.", numberRowMinSum, rowMinSum);
