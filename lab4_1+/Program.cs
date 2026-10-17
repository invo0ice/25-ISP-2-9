//вариант 29 высокий уровень
Console.WriteLine("Введите положительное двоичное число: ");
string a = Console.ReadLine()!;
Console.WriteLine("Введите отрицательное двоичное число: ");
string b = Console.ReadLine()!;
int x = 0;
int y = 0;
for (int i = 0; i < a.Length; i++)
{
    x = x * 2 + (a[i] - '0');
}
for (int i = 0; i < b.Length; i++)
{
    y = y * 2 + (b[i] - '0');
}
int sum = x - y;
Console.WriteLine($"Сумма чисел: {sum}");