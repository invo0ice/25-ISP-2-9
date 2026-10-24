string s = Console.ReadLine()!;
char b = char.Parse(Console.ReadLine()!);
string[] a = s.Split(' ');
for (int i = 0; i < a.Length; i++)
{
    if (a[i][0] == b)
    {
        Console.WriteLine(a[i]);
    }
}