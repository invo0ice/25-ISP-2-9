//try
//{
//    Console.WriteLine("Введите x: ");
//    double x = double.Parse(Console.ReadLine());
//    if (x < 4) Console.WriteLine("Первая область ");
//    else Console.WriteLine("Вторая область");

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.WriteLine("Введите x: ");
//    double x = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите y: ");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if (x > y)
//    {
//        max = x;
//        min = y;
//    }
//    else
//    {
//        max = y;
//        min = x;
//    }
//    Console.WriteLine($"max={max}, min={min}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.WriteLine("Введите a: ");
//    double a = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите b: ");
//    double b = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите c: ");
//    double c = double.Parse(Console.ReadLine());
//    if((a<b)&&(b<c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("Не выполняется");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите m: ");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m / 10 % 10;
//    int c = m % 10;
//    if ((a == 4) || (b == 4) || (c == 4) || (a == 7) || (b == 7) || (c == 7))
//        Console.WriteLine("Да");
//    else Console.WriteLine("нет");
//    if ((a == 3) || (b == 3) || (c == 3) || (a == 6) || (b == 6) || (c == 6) || (a == 9) || (b == 9) || (c == 9))
//        Console.WriteLine("да");
//    else Console.WriteLine("нет");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.WriteLine("Введите число: ");
//    int m = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите другое число: ");
//    int b = int.Parse(Console.ReadLine());
//    int x = m / 100;
//    int y = m / 10 % 10;
//    int z = m % 10;
//    int v = x + y + z;
//    if (x * y * z > b) Console.WriteLine("Произведение цифр первого числа больше второго числа");
//    else Console.WriteLine("Произведение цифр первого числа меньше второго числа");
//    if (v % 3 == 0) Console.WriteLine("Сумма цифр первого числа кратна трём");
//    else Console.WriteLine("Сумма цифр первого числа не кратна трём");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}