namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int negative = 0, zero = 0, pozitive = 0;
            int numere;
            for(int i = 0; i < n; i++)
            {
                numere = int.Parse(Console.ReadLine());
                if (numere < 0)
                    negative++;
                else if (numere > 0)
                    pozitive++;
                else zero++;
            }
            Console.WriteLine($" pozitive: {pozitive}, negative: {negative}, zero: {zero}");
                
        }
    }
}
