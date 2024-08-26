/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os, exibindo o total de moedas coletadas ao final.
@Lista: 01 - Lógica de Programação
@Autor: Chagas Junior
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {

        double r1, r2, r3, r4, r5, soma;

        Console.Write("qual o valor da moeda 1: ");
        double.TryParse(Console.ReadLine(), out r1);


        Console.Write("qual o valor da moeda 2: ");
        double.TryParse(Console.ReadLine(), out r2);

        Console.Write("qual o valor da moeda 3: ");
        double.TryParse(Console.ReadLine(), out r3);

        Console.Write("qual o valor da moeda 4: ");
        double.TryParse(Console.ReadLine(), out r4);

        Console.Write("qual o valor da moeda 5: ");
        double.TryParse(Console.ReadLine(), out r5);


      soma = r1 + r2 + r3 + r4 + r5;

        Console.Write("seu valor total é de: " + soma);
        Console.ReadLine();
    }
}