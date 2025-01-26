namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int pozitie = -1;
            int numere;
            for(int i=0; i<n; i++)
            {
                numere = int.Parse(Console.ReadLine());
               if (numere == a)
                    pozitie = i;
            }
            if (pozitie != -1)
                Console.WriteLine(pozitie);
            else Console.WriteLine("NU");
        }
    }
}
