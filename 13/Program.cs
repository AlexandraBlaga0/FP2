namespace _13
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
        static bool crescatoare(int n, int[] v)
        {
            for (int i = 0; i < n - 1; i++)
                if (v[i] > v[i + 1])
                    return false;
            return true;
        }
        static bool verificare(int n, int[] v)
        {
            for (int i = 0; i < n; i++)
            {
                if (crescatoare(n, v))
                    return true;
                else
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
            if (verificare(n, v))
                Console.WriteLine(" poate fi rotit");
            else
                Console.WriteLine("nu poate fi rotit");
        }

    }
}
