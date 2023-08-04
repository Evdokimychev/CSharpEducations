// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

// Пример:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 31. Создание массива и назождение сумм положительных и отрицательных элементов";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
    Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
            Найдите сумму отрицательных и положительных элементов массива.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, создающего массив по данным параметрам
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
int positiveSum = GetPositiveSum(array);
int negativeSum = GetNegativeSum(array);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");
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

// Возвращает сумму положительных чисел массива arr
int GetPositiveSum(int[] arr)
{
    int positiveSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveSum += el;
    }
    return positiveSum;
}
// Возвращает сумму отрицательных чисел массива arr
int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        negativeSum += el < 0 ? el : 0;
    }
    return negativeSum;
}

// ---------------------- Конец определения методов ----------------------------