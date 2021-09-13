using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int option;

            do
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: "+alcool);
                        Console.WriteLine("Gasolina: "+gasolina);
                        Console.WriteLine("Diesel: "+diesel);
                        break;
                    default:   
                     continue;
                }
            } while (option != 4);
        }
    }
}
