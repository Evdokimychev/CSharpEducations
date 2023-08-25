// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Пример:
// 45 -> 101101;
// 3  -> 11;
// 2  -> 10;

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 42. Преобразование десятичных чисел в двоичные";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
    Напишите программу, которая будет преобразовывать десятичное число в двоичное.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int decimalNumber = GetNumberFromUser ("Введите десятичное число: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода проверки возможности существования треугольника
int[] binaryNumber = FindBinaryNumber (decimalNumber);
// PrintArray (binaryNumber);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Выводим результат в консоль согласно примеру
Console.WriteLine($"\nДесятичное число {decimalNumber} в двоичном выражении будет -> "); 
PrintArray(binaryNumber);
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------

// Метод запроса данных у пользователя
static int GetNumberFromUser (string welcomeMessage, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(welcomeMessage);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

// Метод вывода массива в консоль
void PrintArray(int[] ArrayToPrint)
{
    // Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]}");
        if (i < ArrayToPrint.Length - 1)
        {
            // Console.Write(", ");
        }
    }
    // Console.WriteLine("]");
}


// Метод преобразования десятичного числа в двоичное;
int[] FindBinaryNumber (int decimalNumber)
{
    int interim = decimalNumber;
    int binArraySize = 0;
    for (binArraySize = 0; interim > 0; binArraySize++)
        interim = interim / 2;
    int[] binArray = new int [binArraySize];
    for (int i = binArraySize - 1; i >= 0; i--)
    {
        binArray[i] = decimalNumber % 2;
        decimalNumber = decimalNumber / 2;
    }
    return binArray;
}
// ---------------------- Конец определения методов ----------------------------

/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

// int InputN()
// {
//     int NumberToInput = 0;
//     Console.Write($"Введите число: ");
//     NumberToInput = Convert.ToInt32(Console.ReadLine());
//     return NumberToInput;
// }
// void PrintArray(int[] ArrayToPrint)
// {
//     Console.Write("[");
//     for (int i = 0; i < ArrayToPrint.Length; i++)
//     {
//         Console.Write($"{ArrayToPrint[i]}");
//         if (i < ArrayToPrint.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.WriteLine("]");
// }

// int[] DecToBinConvert(int decNumberToConvert)
// {
//     int temp = decNumberToConvert;
//     int binArraySize = 0;
//     for (binArraySize = 0; temp > 0; binArraySize++)
//         temp = temp / 2;
//     int[] binArray = new int[binArraySize];
//     for (int i = binArraySize - 1; i >= 0; i--)
//     {
//         binArray[i] = decNumberToConvert % 2;
//         decNumberToConvert = decNumberToConvert / 2;
//     }
//     return binArray;
// }



// int decNumber = InputN();
// int[] binNumberArray = DecToBinConvert(decNumber);

// Console.WriteLine("Число {0} в двоичной системе:", decNumber);
// PrintArray(binNumberArray);