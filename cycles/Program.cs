//int s = 0;
//int k = 0;
//int n = 0;
//Console.WriteLine("Введите числа");
//do
//{
//    try
//    {
//        n = int.Parse(Console.ReadLine());
//        s += n;
//        k ++;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (n!=0);
//k--;
//Console.WriteLine($"Сумма чисел:{s}, количество: {k}");

//double s = 0;
//int k  = 0;
//do
//{ 
//    try
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) break;
//        s += n;
//        k++;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (true);
//Console.WriteLine($"Среднее арифметическое: {s/k:F2}");

//int s = 0;
//int i = 0;
//while (i < 11)
//{
//    i++;
//    if (i%5==0) continue;
//    s += i;
//}
//Console.WriteLine($"S={s}");

//for(int i=35;i<=87; i++)
//{
//    if(i%7==1||i%7==2||i%7==5) Console.WriteLine(i+"");
//}

//Console.WriteLine("Введите чилсо:");
//int n = int.Parse(Console.ReadLine());
//int k3 = 0;
//int kLast = 0;
//int kOdd  = 0;
//int sumGreater5  = 0;
//long multGreater7 = 1;
//int k05  = 0;
//int last = n % 10;
//while (n != 0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if (temp == last) kLast++;
//    if (temp%2==0) kOdd++;
//    if (temp > 5) sumGreater5 += temp;
//    if (temp>7) multGreater7 *= temp;
//    if (temp == 0 || temp==5)k05++;
//    n = n / 10;
//}
//Console.WriteLine($"Количество 3:{k3}");
//Console.WriteLine($"Последняя цифра встречается:{kLast}");
//Console.WriteLine($"Количество четных:{kOdd}");
//Console.WriteLine($"Сумма больше 5:{sumGreater5}");
//Console.WriteLine($"Произведение его цифр, больших семи:{multGreater7}");
//Console.WriteLine($"Встречаются цифры 0 и 5:{k05}");

//for (int i = 1; i <= 9; i++)//внешний цикл
//{
//    for (int j = 1; j <= 9; j++)//внутренний цикл
//    {
//        Console.WriteLine($"{i}*{j}={i*j}");
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(i * 10 + " ");
//    }
//    Console.WriteLine();
//}

