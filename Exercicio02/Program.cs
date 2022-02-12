using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura;
            int altura;
            string A = "";
            string B = "";



            Console.WriteLine("Favor colocar a Largura do Retangulo");

            largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Favor colocar a altura do Retangulo");

            altura = Convert.ToInt32(Console.ReadLine());

            int total = altura;

            for (int i = 0; i < largura; i++)
            {
                A += "A";
                B += "B";
            }

            for (int i = 0; i < total; i++)
            {

                string[] ast = new string[i + 1];
                if (i%2==0)
                {
                    ast[i] = A;

                }else if (i%2==1) {
                    ast[i] = B;
                }
                
                Console.WriteLine(ast[i]);

            }
        }
    }
}
