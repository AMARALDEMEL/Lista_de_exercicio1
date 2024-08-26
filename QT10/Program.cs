/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida 
* Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a 
cada nível alcançado. 
* Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida 
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível. 

@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {

        int vida, nivel, nivelA, total;

        Console.Write("qual a sua vida??: ");
        int.TryParse(Console.ReadLine(), out vida);


        Console.Write("qual o aumento do seu nivel?: ");
        int.TryParse(Console.ReadLine(), out nivel);

        Console.Write("qual o seu nivel alcançado?: ");
        int.TryParse(Console.ReadLine(), out nivelA);

        
        total = ((nivel * nivelA) + vida);

        Console.WriteLine("os pontos de vida finais sao de: " + (total));

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}