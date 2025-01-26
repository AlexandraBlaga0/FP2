namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool crescator = true;
            bool descrescator = true;

            int a = int.Parse(Console.ReadLine());
            int b;

            for (int i = 0; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b < a)
                    crescator = false;
                if (b > a)
                    descrescator = false;
            }
            if (crescator)
                Console.WriteLine("monoton crescatoare");
            else if (descrescator)
                Console.WriteLine("monoton descrescatoare");
            else
                Console.WriteLine("nu este monoton");
        }
    }
}
