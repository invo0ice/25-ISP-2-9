int inch = 1;
Console.WriteLine("Дюймы в Сантиметры");
while (inch <= 20)
{
    double sm = inch * 2.54;
    Console.WriteLine($"{inch}  {sm:F2}");
    inch++;
}
