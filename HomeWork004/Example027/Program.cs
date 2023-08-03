// Задача 27: : Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// Пример:
// 452 -> 11
// 82 -> 10

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 27. Определение суммы цифр введённого числа пользователем";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
        Напишите программу, которая принимает на вход число 
                и выдаёт сумму цифр в числе.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число.
int number = GetNumberFromUser ("Введите число: ", "Ошибка ввода данных!");
int len = NumberLen(number);
int sum = GetSumNumbers(number, len);
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// int number;
// try
// {
//     // result = GetSumNumber (number);
//     GetSumNumbers (number, len);
// }
// catch(Exception exc)
// {
//     Console.WriteLine($"ОШИБКА! {exc.Message}");
//     return; // Завершение программы в случае ошибки
// }
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"{number} -> {sum}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
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
       
        // Вариант 2 (Преподавателя)
        // Console.Write(welcomeMessage);
        // bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        // if (isCorrect)
        //     return userNumber;
        // Console.Write(errorMessage);
    }
}

// Определяем функции определения суммы цифр

// Функция подсчета цифр в числе
int NumberLen(int a)
{
 int index = 0;
 while (a > 0)
    {
 a /= 10;
 index++;
    }
 return index;
}

// Функция вывода суммы цифр в числе
int GetSumNumbers(int n, int len)
{
 int sum = 0;
 for (int i = 1; i <= len; i++)
    {
 sum += n % 10;
 n /= 10;
    }
    return sum;
}
// ---------------------- Конец определения методов ----------------------------


