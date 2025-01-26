namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int numere = 0,numar;
            for(int i=0; i<n; i++)
            {
                numar= int.Parse(Console.ReadLine());
                if (numar == i)
                    numere++;
            }
            Console.WriteLine(numere);
        }
    }
}
