class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4 };
        foreach (int value in array)
        {
            Console.Write(value);
        }
        Console.WriteLine();


        Array.Reverse(array);
        foreach (int value in array)
        {
            Console.Write(value);
        }
        Console.WriteLine();
        }
    }