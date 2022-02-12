using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura;
            int altura;
            string soma = "";

            

            Console.WriteLine("Favor colocar a Largura do Retangulo");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Favor colocar a altura do Retangulo");
            altura = Convert.ToInt32(Console.ReadLine());
            int total = altura;

            for (int i = 0; i < largura  ; i++)
            {
                soma += "*";
            }

            for (int i = 0; i < total; i++)
            {
                
                string[] ast = new string[i+1];
                ast[i] = soma;
                Console.WriteLine(ast[i]);

            }
            
        }
    }
}
