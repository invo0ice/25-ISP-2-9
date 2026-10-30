//int[] mas1 = new int[5];
//int [] mas2 = {1,4,2,9,3};
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);

//ввод вручную
//int[] mas4= new int[5];
//for(int i = 0; i < mas4.Length; i++)
//    mas4[i]=int.Parse(Console.ReadLine());
//for (int i = 0; i < mas4.Length; i++)
//    Console.WriteLine($"{mas4[i]}");

//ввод по формуле
//int[] mas5 = new int[5];
//for(int i = 0;i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.Write($"{mas5[i]}");
//}
//Console.WriteLine();

//использование генератора случайных чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(5,15)];
//for(int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] = rnd.Next(1,100);
//    Console.WriteLine($"{mas6[i]}");
//}

//int[] mas = new int[10];
//Random rnd = new Random();
//try
//{
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-7, 8);
//        Console.Write($"{mas[i]}");
//    }
//    Console.WriteLine();
//    Console.Write("Введите n: ");
//    int n = int.Parse(Console.ReadLine());
//    int index = -1;
//    int less_n = 0;
//    for (int i = 0; i < n; i++) 
//    {
//        if (mas[i] == n) index = i;
//        if (mas[i] < n) less_n++;
//    }
//    Console.WriteLine($"Индекс последнего вхождения {n} = {index}");
//    Console.WriteLine($"Количество элементов меньших {n} = {less_n}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите n ");
//    int n = int.Parse(Console.ReadLine());
//    Random rnd = new Random();
//    int[] mas = new int[n];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-10, 11);
//        Console.WriteLine($"{mas[i]}");
//    }
//    Console.WriteLine();
//    int max = mas[0];
//    for (int i = 1; i < mas.Length; i++)
//    {
//        if (mas[i] > max) max = mas[i];
//    }
//    Console.WriteLine($"max={max}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//отсортировать элементы массива по возростанию
//Random rnd = new Random();
//int[] mas = new int[rnd.Next(10, 20)];
//for(int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(10,100);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//for(int i = 0;i < mas.Length-1; i++)
//{
//    for (int j = i+1;j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//foreach (int i in mas) Console.Write($"{i} ");
//Console.WriteLine();

//try
//{
//    Console.Write("Введите размер массива: ");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int s = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-13, 12);
//        Console.Write($"{mas[i]} ");
//        s += mas[i];
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите размер массива: ");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int p = 1;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-19, 26);
//        Console.Write($"{mas[i]} ");
//        if (i % 2 != 0) p *= mas[i];
//    }
//    Console.Write($"s={p}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//string? name = null;
//Console.WriteLine(name);
//int n = int.Parse(Console.ReadLine()!);

//string? text = "Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id  = 200;
//int personId = id ?? 1;
//Console.WriteLine(personId);

//30 базовый уровень
//Random random = new Random();
//double[] mas = new double[12];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = mas[0];
//int index = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] < min)
//    {
//        min = mas[i]; index = i;
//    }
//}
//Console.WriteLine($"Сумма минимального элемента и его индекса: {min + index:F2}");

//30 средний уровень
//Random random = new Random();
//double[] mas1 = new double[random.Next(10, 20)];
//double[] mas2 = new double[random.Next(10, 20)];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.NextDouble() * 100;
//    Console.Write($"{mas1[i]:F2} ");
//}
//Console.WriteLine();
//double min1 = mas1[0];
//int index = 0;
//for (int i = 0; i < mas1.Length; i++)
//{
//    if (mas1[i] < min1)
//    {
//        min1 = mas1[i]; index = i;
//    }
//}
//Console.WriteLine($"Сумма минимального элемента и его индекса: {min1 + index:F2}");


//Двумерные массивы

//Random rnd = new Random();
//int[,] mas = new int[4, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-5, 6);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//int min = mas[0, 0];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] < min) min = mas[i, j];
//    }
//}
//Console.WriteLine();
//Console.WriteLine($"min={min} ");
//Console.WriteLine();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] % 2 == 0) mas[i, j] *= 2;
//        else mas[i, j] *= 3;
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}

//Random rnd = new Random();
//int n = rnd.Next(3, 10);
//int[,] mas = new int[n, n];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine( );
//} 
//double S = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(0); j++)
//    {
//        if (i == j) S += mas[i, j];
//    }
//}
//Console.WriteLine($"{S/mas.GetLength(0)} ");

//baza
//Random rnd  = new Random();
//int[,] mas = new int[rnd.Next(4,9), rnd.Next(4,9)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i,j]}  ");
//    }
//    Console.WriteLine();
//}
//int count  = 0;
//for (int i = 0;i < mas.GetLength(0); i++)
//{
//    if (mas[i, 1] >= 0) count++;
//}
//Console.WriteLine($"Количество не отрицательных элементов во втором столбце: {count} ");

//int[] a = new int[5];
//Random r = new Random();
//for(int i = 0; i < a.Length; i++)
//{
//    a[i] = r.Next(1,10);
//    Console.Write(a[i]+" ");
//}
//Console.WriteLine();
//Array.Clear(a);
//for (int i = 0; i < a.Length; i++)
//{
//    a[i] = r.Next(1, 10);
//    Console.Write(a[i] + " ");
//}
//Console.WriteLine();
//int[] b = new int[5];
//a.CopyTo(b);
//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write(b[i] + " ");
//}
//Console.WriteLine();
//Array.Sort(b);
//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write(b[i] + " ");
//}
//Console.WriteLine();

using System.Text.RegularExpressions;

//string s = "Бык тупогуб, тупогубенький бычок, у быка бела губа была тупа";
//Regex regex = new Regex(@"туп(\m*)");
//MatchCollection matches = regex.Matches(s);
//if(matches.Count > 0)
//{
//    foreach(Match match in matches)
//        Console.WriteLine(match.Value);
//}
//else Console.WriteLine("Нет совпадений");


Console.Write("Введите строку: ");
string s = Console.ReadLine()!;
string pattern = "[0-9]";

if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine("Цифра есть");
else Console.WriteLine("Цифры нет");

