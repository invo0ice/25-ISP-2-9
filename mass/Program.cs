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

//высокий уровень
Random random = new Random();
