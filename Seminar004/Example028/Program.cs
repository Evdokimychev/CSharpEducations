// Задача 28: : Напишите программу, которая принимает на вход число (N) 
// и выдаёт произведение чисел от 1 до N

// Пример:
// 4 -> 24 (1*2*3*4=24)
// 5 -> 120

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 28. Выдача произведения чисел от 1 до введённого числа пользователем";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
        Напишите программу, которая принимает на вход число (N) 
                    и выдаёт произведение чисел от 1 до N
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число (А).
int number = GetNumberFromUser ("Введите число N: ", "Ошибка ввода данных!");
int productNumbers = GetProductNumbers (number);
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// string result;
// try
// {
//     // result = GetSummNumber (number);
//     GetProductNumbers (number);
// }
// catch(Exception exc)
// {
//     Console.WriteLine($"ОШИБКА! {exc.Message}");
//     return; // Завершение программы в случае ошибки
// }
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"{number} -> {productNumbers}");
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

// Определяем функцию определения произведения чисел от 1 до числа N

int GetProductNumbers (int number)
{
    int product = 1;
    while (number > 0)
    {
        product *= number;
        number--;
    }
    return product;
}
// ---------------------- Конец определения методов ----------------------------
