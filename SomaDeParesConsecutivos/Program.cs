using System;

namespace SomaDeParesConsecutivos
{

    /* O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0.
     * Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo, se for par.
     * Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação:
     * 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exemplo, a saída deve ser 80,
     * que é a soma de 12+14+16+18+20. */
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0) {
                    break;
                }
                else if (x % 2 == 0)
                {
                    int a = x + 2;
                    int b = a + 2;
                    int c = b + 2;
                    int d = c + 2;
                    int soma = (x + a + b + c + d);

                    Console.WriteLine(soma);
                }
                else
                {
                    int conv = x + 1;
                    int a = conv + 2;
                    int b = a + 2;
                    int c = b + 2;
                    int d = c + 2;
                    int soma = (conv + a + b + c + d);

                    Console.WriteLine(soma);
                }

            }




        }            

    }
}



 



