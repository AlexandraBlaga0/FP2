namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            int a = int.Parse(Console.ReadLine());
            int b;
            for (int i=0; i<n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b<a) ok = false;
                a = b;
            }
            if (ok)
                Console.WriteLine("CRESCATOR");
            else Console.WriteLine("NU");
        }
    }
}
