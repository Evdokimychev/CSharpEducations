// Задача 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// -------------------------- Начало программы ----------------------------------
Console.Clear ();
int quarter = GetNumberFromUser ("Введите номер четверти: ", "Ошибка ввода данных!");
PrintRange (quarter);
Console.WriteLine ("Нажмите любую кнопку");
Console.ReadKey();
// -------------------------- Конец программы ----------------------------------

// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Определяем функцию
static int GetNumberFromUser (string welcomeMessage, string errorMessage)
{
    while (true)
    {
    try
        {
            Console.Write (welcomeMessage);
            int numQuarter = int.Parse (Console.ReadLine () ?? "");
            return numQuarter;
        }
        catch (Exception exc)
        {
            Console.WriteLine ($"{errorMessage} {exc.Message}");
        }
    }
}
// ----------------------------------------------------------------------------
static void PrintRange (int quarter)
{
    if (quarter == 1)
        Console.WriteLine ("x = (0 ... +oo)); y = (0 ... +oo)");
    else if (quarter == 2)
        Console.WriteLine ("x = (-oo ... 0)); y = (-oo ... 0)");
    else if (quarter == 3)
        Console.WriteLine ("x = (-oo ... 0)); y = (0 ... +oo)");
    else if (quarter == 4)
        Console.WriteLine ("x = (0 ... +oo)); y = (-oo ... 0)");
    else
        Console.WriteLine ("Ошибка! Неверно введён номер квадранта!");
}
// ---------------------- Конец определения методов ----------------------------