Random rnd = new Random();
Console.Write("Введите размер матрицы: ");
int n = int.Parse(Console.ReadLine()!);
int[,] mas = new int[n, n];
double p = 1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mas[i, j] = rnd.Next(1,10);
    }
}
Console.WriteLine("Исходная матрица:");
for (int i = 0;i < n; i++)
{
    for (int j = 0;j < n; j++)
    {
        Console.Write(mas[i,j] + "  ");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i > j)
        {
            p *= mas[i, j];
        }
    }
}
Console.WriteLine($"Произведение элементов ниже главной диагонали: {p}");