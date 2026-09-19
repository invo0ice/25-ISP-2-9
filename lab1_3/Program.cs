//Console.WriteLine($"{Math.PI:F2}");

//Console.WriteLine($"{Math.E:F1}");

//int a = int.Parse( Console.ReadLine() );
//Console.WriteLine($"Вы ввели число: {a}");

//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"{a} - Вот такое число вы ввели");

//Console.WriteLine("7  15  100");

//Console.WriteLine("1 13 49");

//try
//{
//    Console.WriteLine("Введите а: ");
//    double a = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите b: ");
//    double b = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите c: ");
//    double c = double.Parse(Console.ReadLine());
//    double x = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//    Console.WriteLine($"x = {x:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите радиус: ");
//    double r = double.Parse(Console.ReadLine());
//    double d = 2 * r;
//    Console.WriteLine($"d = {d:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите кол-во сантиметров: ");
//    int sm=int.Parse(Console.ReadLine());
//    int m=sm/100;
//    Console.WriteLine($"Полных метров {m}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите кол-во килограммов: ");
//    int kg = int.Parse(Console.ReadLine());
//    int c = kg / 100;
//    Console.WriteLine($"Полных центнеров {c}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите кол-во килограммов: ");
//    int kg = int.Parse(Console.ReadLine());
//    int ton = kg / 1000;
//    Console.WriteLine($"Полных тонн {ton}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите кол-во метров: ");
//    int m = int.Parse(Console.ReadLine());
//    int km = m / 1000;
//    Console.WriteLine($"Полных километров {km}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    int d = 234;
//    int n = 234 / 7;
//    Console.WriteLine($"Полных недель: {n}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите кол-во секунд: ");
//    int n = int.Parse(Console.ReadLine());
//    int h = n / 3600;
//    int m = n % 3600/60;
//    int s = n % 3600 % 60;
//    Console.WriteLine($"{h}:{m}:{s}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите четырехзначное число: ");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    int s = a+b+c+d;
//    Console.WriteLine(s);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    Console.Write("Введите номер места: ");
    int place = int.Parse(Console.ReadLine());
    int tier = place/120 + 1;
    int section = place % 120 / 15;
    int ps = place % 120 % 15 + 1;
    Console.WriteLine($"Ярус: {tier}  Секция: {section}  Место в секции: {ps}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}