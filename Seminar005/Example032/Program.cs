// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 32. Создание массива и замена положительных и отрицательных элементов";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                Напишите программу замены элементов массива: 
    положительные элементы замените на соответствующие отрицательные, и наоборот.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, создающего массив по данным параметрам
int[] array = GetArray(4, -10, 10);
// Console.WriteLine(String.Join(" ", array));
PrintArray (array);
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
int[] newArray = replacingTheSign(array);
// Console.WriteLine(String.Join(" ", newArray));
PrintArray (newArray);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Console.WriteLine($"Старый массив = {PrintArray (array)} Новый массив = {PrintArray (newArray)}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Метод изменяет знак на противоположный
int[] replacingTheSign(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for(int i = 0;i < arr.Length; i++)
    {
       newArray[i] = arr[i] * -1;
    }
    return newArray;
}

// Метод вывода массива
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

// ---------------------- Конец определения методов ----------------------------