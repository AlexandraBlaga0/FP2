namespace _16
{
    internal class Program
    {
        static int[] rotire(int n, int[] v)
        {
            int a = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = a;
            return v;


        }
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
        static bool verificare(int n, int[] v)
        {
            for (int i = 0; i < n; i++)
            {
                if (bitonica(n, v))
                    return true;
                rotire(n, v);

            }
            return false;

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            if (verificare(n, v) == true)
                Console.WriteLine("bitonica rotita ");
            else Console.WriteLine("nu");


        }
    }
}
