namespace _11
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int suma = 0, numar;
                for (int i = 0; i < n; i++)
                {
                   numar = int.Parse(Console.ReadLine());
                    suma = suma + (numar) * (-1);
                }
                Console.WriteLine(suma);
            }
        
    }
}
