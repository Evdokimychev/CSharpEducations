// double[] a = new double[5];
// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     a[i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i]);

//     Console.WriteLine();
// }
 double[] res = new double[5];
    for (int i = 0; i < 5; i++)
    {
        res[i] = new Random().NextDouble() * 100;
            Console.Write("{0,6:F2}", res[i]);
        
        Console.WriteLine();

    }