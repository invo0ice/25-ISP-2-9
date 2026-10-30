using System.Text.RegularExpressions;
//базовый уровень вариант 7
Console.Write("Введите строку: ");
string s = Console.ReadLine()!;
string pattern = "[0-9]";

if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine("Цифра есть");
else Console.WriteLine("Цифры нет");