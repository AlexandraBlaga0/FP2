namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int pare = 0;
            int numar;
            for(int i=0; i<n; i++)
            {
                numar= int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                    pare++;

            }
            Console.WriteLine(pare);
        }
    }
}
