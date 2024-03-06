namespace DirectSelectionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, -5, 1, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) 
                    {
                        int swapVar = array[i];
                        array[i] = array[j];
                        array[j] = swapVar;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
