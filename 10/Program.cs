namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b, secventaActuala=1, Secventa=0;
            for(int i=1; i<n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a == b)
                    secventaActuala++;
                else
                { if (secventaActuala > 1)
                        Secventa++;
                    secventaActuala = 0;
                }
                a = b;
            }
            Console.WriteLine(Secventa);
        }
    }
}
