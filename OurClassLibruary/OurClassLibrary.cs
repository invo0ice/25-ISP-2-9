namespace OurLibrary
{
    public class OurClassLibrary
    {
        public static int[] NegSum(int[,] a)
        {
            int[] b = new int[a.GetLength(0)];
            for(int i = 0; i<a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] < 0)
                    {
                        b[i] += a[i, j];
                    }
                }
            }
            return b;
        }

    }
}
