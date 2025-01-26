namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int produs = 1, suma = 0, numere;
            for(int i=1; i<=n; i++)
            {
          
                produs = produs * i;
                suma = suma+i;
            }
            Console.WriteLine($"produs: {produs}, suma: {suma}");
        }
    }
}
