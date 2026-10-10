try
{
    Console.Write("Введите целое число A: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Введите целое чиcло B: ");
    int B = int.Parse(Console.ReadLine());
    int N = 0;
    for (int i = B; A<=i;) 
    {
        Console.Write(A + " ");
        A++;
        N++;
        if (A <= B) continue;
    }
    Console.Write($"Количество чисел {N}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
