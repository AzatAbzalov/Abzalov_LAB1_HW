//Задание 1
//double elem()
//{
//    Console.WriteLine("Введите элемент массива: ");
//    double y = Convert.ToDouble(Console.ReadLine());
//    return y;
//}

//double Fx(double n)
//{

//    if (n <= -3)
//    {
//        return 7.0 / 3.0;
//    }
//    else if (-3 < n && n < 3)
//    {
//        return (-2 + Math.Pow(n,2) * Math.Cos((Math.PI * (n - 1)) / (2 * n)));
//    }
//    else
//    {
//        double y = n + 3;
//        double x = n - 1 / Math.Pow(n - 1, 3);
//        double z = -2 + n;
//        return (y * n) / (x * z);
//    }
//}
//bool striped(double x, double y)
//{
//    if (x >= -4 && x <= 0 && y <= 6 && y >= 0 && y == 2 * x + 6)
//    {
//        return true;
//    }
//    else if (x <= 3 && x > 0 && y <= 6 && y >= -6 && Math.Sqrt(x * x + y * y) == 6)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//double distance(double x, double y)
//{
//    return (Math.Sqrt(x * x + y * y));
//}
//bool quarter(double x, double y)
//{
//    if (x >= 0 && y >= 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.Write("Введите кол-во элементов массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//double[] x = new double[n];
//double[] y = new double[n];
//double[] x1 = new double[n];
//double[] y1 = new double[n];
//for (int i = 0; i < n; i++)
//{
//    x[i]=elem();
//}

//for (int i = 0; i < n; i++)
//{
//    y[i] = Fx(x[i]);
//}
//int count = 0;

//for (int i = 0, t = 0; i < n; i++)
//{
//    if (striped(x[i], y[i]))
//    {
//        count++;
//    }
//    else
//    {
//        Console.WriteLine($"Точка ({x[i]};{y[i]}) не принадлежит области, расстояние от (0,0) до точки равно: {distance(x[i], y[i])}");
//        x1[t] = x[i];
//        y1[t] = y[i];
//        t++;
//    }
//}
//Console.WriteLine($"{count} точек в закрашенной области");
//double X = 0;
//double Y = 0;
//double distance1 = 0;
//for (int i = 0; i < x1.Length; i++)
//{
//    if (quarter(x1[i], y[i]))
//    {
//        if (distance1 < distance(x1[i], y1[i]))
//        {
//            X = x1[i];
//            Y = y1[i];
//            distance1 = distance(x1[i], y1[i]);
//        }
//    }
//}
//Console.WriteLine($"Точка ({X},{Y}) лежит в I четверти и дальше всех от (0,0)");

//Задание 2
//void Rectangle(out double a, out double b)
//{
//    Console.WriteLine("Введите сторону а прямоугольника:");
//    a = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Введите сторону b прямоугольника:");
//    b = Convert.ToDouble(Console.ReadLine());
//}
//void Per(double a, double b, out double perimetr, out double area)
//{
//    perimetr = a + b;
//    area = a * b;
//}
//int n = 3;
//double[] a = new double[n];
//double[] b = new double[n];
//double[] perimetr = new double[n];
//double[] area = new double[n];
//for (int i = 0; i < n; i++)
//{
//    Rectangle(out a[i], out b[i]);
//}
//for (int i = 0; i < n; i++)
//{
//   Per(a[i], b[i], out perimetr[i], out area[i]);
//}
//double maxim = 0;
//for (int i = 0; i < n; i++)
//{
//    if (area[i] > maxim)
//    {
//        maxim = area[i];
//    }
//}
//Console.WriteLine($"Макс.площадь:{maxim}");
//for (int i = 0; i < n; i++)
//{
//    if (perimetr[i] < 15 && perimetr[i] > 7)
//    {
//        Console.WriteLine($"{i}-ый прямоугольник имеет периметр, равный: {perimetr[i]} ");
//    }
//}

//Задание 3
//Random rnd = new Random();
//int n, m;
//Console.WriteLine("Введите количество строк:");
//n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов:");
//m = Convert.ToInt32(Console.ReadLine());
//double[,] a = new double[n, m];
//double min = 0;
//int pox = 0, poy = 0;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = rnd.Next(-10, 10);
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        Console.Write($"{a[i, j]} \t");
//    }
//    Console.WriteLine();
//}
//int[] count = new int[m];
//double[] prod = new double[m];
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        if (a[i, j] > 0)
//        {
//            count[j]++;
//        }
//        if (a[i, j] < min)
//        {
//            min = a[i, j];
//            pox = i;
//            poy = j;
//        }
//    }
//}
//for (int i = 0; i < m; i++)
//{
//    if (count[i] > 0)
//    {
//        prod[i] = 1;
//    }
//    else
//    {
//        prod[i] = 0;
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        if (count[j] > 0 && a[i, j] != 0)
//        {
//            prod[j] = prod[j] * a[i, j];
//        }
//    }
//}
//for (int i = 0; i < m; i++)
//{
//    if (count[i] > 0)
//    {
//        Console.WriteLine($"Произведение элементов {i + 1} столбца:{prod[i]}");
//    }
//}
//int i1 = 0;
//int j1 = 0;
//int count1 = 1;
//while (a[pox, poy] != a[i1, j1])
//{
//    if (j1 < m - 1)
//    {
//        count1++;
//        j1++;
//    }
//    else
//    {
//        count1++;
//        i1++;
//        j1 = 0;
//    }
//}
//double[] arr = new double[count1];
//for (int i = 0; i < count1; i++)
//{
//    arr[i] = 0;
//}
//count1 = 0;
//i1 = 0; j1 = 0;
//while (a[pox, poy] != a[i1, j1])
//{
//    if (j1 < m - 1)
//    {
//        arr[count1] += a[i1, j1];
//        j1++;
//    }
//    else
//    {
//        arr[count1] += a[i1, j1];
//        i1++;
//        j1 = 0;
//    }
//    count1++;
//}
//Console.Write("Элементы, расположенные до минимального:");
//for (int j = 0; j < count1; j++)
//{
//    Console.Write($"{arr[j]} ");
//}