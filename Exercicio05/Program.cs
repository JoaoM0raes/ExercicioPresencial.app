using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dadosUm = new Random();

            Random dadosDois = new Random();

            string jogadorNúmeroUm;
            
            string jogadorNúmeroDois;

            int pontuaçãoUm;

            int pontuaçãoDois;

            int pontuaçãoTotalUm = 0;

            int pontuaçãoTotalDois = 0;

            int conta = 0;

            Console.WriteLine("Escreva o Nome do jogador Um: ");

            jogadorNúmeroUm = Console.ReadLine();

            Console.WriteLine("Escreva o Nome do jogador Dois: ");

            jogadorNúmeroDois = Console.ReadLine();

            while (conta<3){
                
                conta++;

                Console.WriteLine($"{conta}ª Rodada ");

                pontuaçãoUm = dadosUm.Next(6);
                Console.WriteLine($"{jogadorNúmeroUm} jogou : {pontuaçãoUm}");

                pontuaçãoDois = dadosDois.Next(7);
                Console.WriteLine($"{jogadorNúmeroDois} jogou : {pontuaçãoDois}");

                if (pontuaçãoUm > pontuaçãoDois)
                {
                    pontuaçãoTotalUm++;
                    Console.WriteLine($"O {jogadorNúmeroUm} venceu a {conta}ª rodada");
                }
                else if (pontuaçãoDois > pontuaçãoUm)
                {
                    pontuaçãoTotalDois++;
                    Console.WriteLine($"O {jogadorNúmeroDois} venceu a {conta}ª rodada");
                }
                else
                {
                    Console.WriteLine($"A {conta}ª rodada terminou empatada");
                    pontuaçãoTotalUm++;
                    pontuaçãoTotalDois++;
                }
            }
            if (pontuaçãoTotalUm> pontuaçãoTotalDois)
            {
                Console.WriteLine($"O {jogadorNúmeroUm} foi o vencedor por {pontuaçãoTotalUm} a {pontuaçãoTotalDois}");
            }
            else if (pontuaçãoTotalDois > pontuaçãoTotalUm)
            {
                Console.WriteLine($"O {jogadorNúmeroDois} foi o vencedor por {pontuaçãoTotalDois} a {pontuaçãoTotalUm}");
            }else
            {
                Console.WriteLine($"O jogo terminou empatado a {pontuaçãoTotalUm} a {pontuaçãoTotalDois} ");
            }
            


        }
    }
}
