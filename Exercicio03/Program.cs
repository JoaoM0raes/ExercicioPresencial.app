using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horario = 0;
            string dia = DateTime.Now.ToString("HH");
            Console.WriteLine("Agora é: " + dia );
            horario = Convert.ToInt32(dia);
            
            if(horario>=6 && horario <= 12)
            {
                Console.WriteLine("Bom Dia!!");
            }
            else if (horario >= 12 && horario <= 18)
            {
                Console.WriteLine("Boa Tarde!!");
            }
            else 
            {
                Console.WriteLine("Boa Noite!!");
            }
        }
    }
}
