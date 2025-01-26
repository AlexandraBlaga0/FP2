namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int numar = int.Parse(Console.ReadLine());
            int max, min;
            max = numar;
            min = numar;
            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(Console.ReadLine());
                if (numar > max)
                    max = numar;
                if (numar < min)
                    min = numar;
            }
            Console.WriteLine($"maxim {max}, minim {min}");

        }
    }
}
