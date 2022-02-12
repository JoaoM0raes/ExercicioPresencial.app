using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float conta = 0;

            float postivo = 0;

            float negativo = 0;

            float juntar;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escreve o " +(i+1) +"∘" + " Número");
                juntar = float.Parse(Console.ReadLine());
                if (juntar  <0)
                {
                    negativo++;
                }
                else
                {
                    postivo++;
                }
                conta += juntar / 5;
                              
            }
            Console.WriteLine($"A Conta total deu: {conta}" );
            Console.WriteLine($"Números negativos: {negativo}");
            Console.WriteLine($"Números positivos: {postivo}");


            
        }
    }
}
