// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Пример:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 44. Поиск числа Фибоначчи";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
    Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
                                Пример: Если N = 5 -> 0 1 1 2 3
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int numberN = GetNumberFromUser ("Введите число N: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода преобразования десятичного числа в двоичное;
int[] fibonachyNumber = FindFibonachyNumber (numberN);
// PrintArray (fibonachyNumber);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Выводим результат в консоль согласно примеру
Console.WriteLine($"\nЕсли число N = {numberN}, то число Фибоначчи -> ");
PrintArray (fibonachyNumber);
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
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}


// Метод преобразования десятичного числа в двоичное;
static int[] FindFibonachyNumber (int numberN)
{
    int[] fibonachyArray = new int [numberN];
    fibonachyArray[0] = 0;
    fibonachyArray[1] = 1;
    for (int i = 2; i < fibonachyArray.Length; i++)
    {
        fibonachyArray[i] = fibonachyArray[i-1]+ fibonachyArray[i-2];
    }
    return fibonachyArray;
}
    
// ---------------------- Конец определения методов ----------------------------