namespace _8
{
    internal class Program
    {
        static int fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1;
            int c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Al {n}-lea termen  este: {fibonacci(n)}");
        }

    }
}
