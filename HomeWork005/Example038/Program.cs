// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// Пример:
// [3 7 22 2 78] -> 76

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 38. Создание массива из вещественных чисел и поиск разницы между максимальным и минимальным элементом массива";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                        Задайте массив вещественных чисел.
        Найдите разницу между максимальным и минимальным элементов массива.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int count = GetNumberFromUser ("Введите количество элементов в массиве: ", "Ошибка ввода данных!");
// double minValue = GetNumberFromUser ("Введите минимальное значение в массиве: ", "Ошибка ввода данных!");
// double maxValue = GetNumberFromUser ("Введите максимальное значение в массиве: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода, создающего массив по данным параметрам
double[] array = GetArray(count); // (count, minValue, maxValue);

// Вызов метода, выводящего созданный массив в консоль
PrintArray (array);

// Считаем разницу между max и min элементами массива
double result = (MaxMinSubtraction(array));

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"\nРазница между максимальным и минимальным элементов в массиве -> {result}");
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

// Метод, создающий массив. Возвращает массив из size элементов, заполненный случайными числами из промежутка
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 100;
        //     Console.Write("{0,6:F2}", res[i]);
        
        // Console.WriteLine();
    }
    return res;
}

// Метод вывода массива
void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0,6:F2}",array[i]);
        Console.Write (", ");
    }
    Console.Write("{0,6:F2}",array[array.Length - 1]);
    Console.Write("]");
}

// Метод рассчета разницы мужду Max и Min элементами массива
double MaxMinSubtraction(double[] array)
{

    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];

        else if (min > array[i]) min = array[i];
            i = i + 1;
    }
    return max-min;
}

// ---------------------- Конец определения методов ----------------------------