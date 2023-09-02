// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

(int, int) GetArraySize()
{
    int rowSize = 0;
    int colSize = 0;
    string enteredSymbol = string.Empty;
    do
    {
        Console.Clear();
        Console.Write("Создать случайные 2D массивы? Нажмите y/n: ");
        enteredSymbol = Console.ReadLine();
        if (enteredSymbol == "y")
        {
            rowSize = new Random().Next(2, 8);
            colSize = rowSize;
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
            if (rowSize == colSize)
            {
                break;
            }
            else
            {
                Console.WriteLine();
                Console.Write("Ошибка! Матрицы должны быть квадратными! Введены m = {0} и n = {1}.",
                                 rowSize, colSize);
                Console.ReadKey();
            }
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
void Print2DArray(int[,] ArrayToPrint, int xPosition, int yPosition, string name = "")
{
    if (name != "")
    {
        Console.SetCursorPosition((xPosition - name.Length / 2 + (ArrayToPrint.GetLength(1) * 7) / 2), yPosition);
        Console.Write("{0}", name);
        yPosition++;
    }
    Console.SetCursorPosition(xPosition, yPosition);
    Console.Write("[X]\t");
    for (int i = 0; i < ArrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t", i);
    }
    yPosition++;
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        Console.SetCursorPosition(xPosition, yPosition++);
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
    }
}
int[,] Multiply2DArrays(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

int rowSize = 0;
int colSize = 0;

(rowSize, colSize) = GetArraySize();
int cursorX = 0, cursorY = 0;

int[,] firstArray = new int[rowSize, colSize];
int[,] secondArray = new int[rowSize, colSize];
Fill2DArray(firstArray);
Fill2DArray(secondArray);
Console.WriteLine();
(cursorX, cursorY) = Console.GetCursorPosition();
Print2DArray(firstArray, cursorX, cursorY, "Матрица 1");

Print2DArray(secondArray, cursorX + 16 + firstArray.GetLength(1) * 7, cursorY, "Матрица 2");

int[,] resultArray = new int[rowSize, colSize];
resultArray = Multiply2DArrays(firstArray, secondArray);

(cursorX, cursorY) = Console.GetCursorPosition();
cursorY += 2;
Print2DArray(resultArray, cursorX / 2 - (firstArray.GetLength(1) * 8) / 2, cursorY, "Результат умножения матриц");
Console.WriteLine();