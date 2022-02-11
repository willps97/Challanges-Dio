using System;

namespace QuadradoEAoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= n; i++)
            {
                
                int quadr = i * i;
                int cubo = i * i * i;

                Console.WriteLine(i + " "+quadr+" "+cubo);
            }
        }
    }
}
