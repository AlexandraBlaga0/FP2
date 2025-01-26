namespace _15
{
    internal class Program
    {
        static bool bitonica(int n, int[] v)
        {
            int i = 0;

            while (i < n - 1 && v[i] < v[i + 1])
                i++;
            if (i == 0 || i == n - 1)
                return false;

            while (i < n - 1 && v[i] > v[i + 1])
                i++;
            if (i == n - 1)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            if (bitonica(n, v))
                Console.WriteLine("bitonica");
            else Console.WriteLine("nu");


        }
    }
}
