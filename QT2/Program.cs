
/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Quantos inimigos foram derrotados?");
        double derrotados;
        double.TryParse(Console.ReadLine(), out derrotados);

        Console.WriteLine("quantos pontos cada inimigo vale?");
        double pontos;
        double.TryParse(Console.ReadLine(), out pontos);

        Console.WriteLine("Qual o bonus da missão?");
        double bonus;
        double.TryParse(Console.ReadLine(), out bonus);

        Console.WriteLine("Qual o tipo de inimigo?");
        double tipo;
        double.TryParse(Console.ReadLine(), out tipo);

        Console.WriteLine("Qual a difuculdade?");
        double dificuldade;
        double.TryParse(Console.ReadLine(), out dificuldade);

        double pontosTotais = (((derrotados * pontos) * tipo) * dificuldade) + bonus;
         Console.WriteLine("sua pontuação foi de: " + pontosTotais);

         Console.WriteLine("precione ENTER para sair");
         Console.ReadLine();




        




        
        


    } 
}       