
Console.Clear ();
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write ("[");
    while (position < count)
    {
        if (position < col.Length - 1) 
            Console.Write ($"{col[position]}, ");
        else
            Console.Write ($"{col[position]}");
        
    position++;
        // return использовать в функции void не нужно
    }
    Console.Write ("]");
}

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

int[] GenMassiv(int count, int min, int max)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int count = GetNumberFromUser ("Введите количество элементов в массиве: ", "Ошибка ввода данных!");
int min = GetNumberFromUser ("Введите минимальное значение в массиве: ", "Ошибка ввода данных!");
int max = GetNumberFromUser ("Введите максимальное значение в массиве: ", "Ошибка ввода данных!");

int[] array = GenMassiv (count, min, max); // Создание нового массива с 8 элементами

// FillArray(array);
// array[4] = 4;
// array[6] = 4;

PrintArray(array);
Console.WriteLine();

// Вариант решения без метода
// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
// }

// Console.Write ("[");
// for (int i = 0; i < array.Length; i++)
// {
//     if (i < array.Length - 1)
//         Console.Write($"{array[i]}, ");
//     else
//         Console.Write($"{array[i]}");
// }
// Console.Write ("]");