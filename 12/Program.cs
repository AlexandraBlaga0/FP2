namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] v= new int[n];
           for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            string cuvant = "";
            for (int i = 0; i < n; i++)
                cuvant = cuvant + v[i];
            string[] cuvinte= cuvant.Split('0');
          
            int secvente = 0;
            for (int i = 0; i < cuvinte.Length; i++)
                if (cuvinte[i]!="")
                    secvente++;
            Console.WriteLine(secvente);
        }
    }
}
