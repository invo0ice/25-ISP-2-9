using OurLibrary;

Random random = new Random();
int[,] a = new int[7, 5];
for (int i = 0; i < 7; i++)
{
  for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.Next(-10, 11);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[] b = OurClassLibrary.NegSum(a);
Console.WriteLine("Сумма массива: ");
for (int i = 0;i < 7; i++)
{
    Console.Write(b[i] + " ");
}
 
