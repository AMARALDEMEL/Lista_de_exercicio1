
/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
•
Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por cristais.
•
Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de conversão
 (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos e outro em habilidades),
  e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int moeda, taxa;

        double evento, habilidade, total;

        Console.Write("quantas moedas foram coletadas?: ");
        int.TryParse(Console.ReadLine(), out moeda);


        Console.Write("qual a sua taxa de habilidade?: ");
        int.TryParse(Console.ReadLine(), out taxa);

        Console.Write("qual o bonus que foi conseguido no evento?: ");
        double.TryParse(Console.ReadLine(), out evento);

        Console.Write("qual o bonus de sua habilidade?: ");
        double.TryParse(Console.ReadLine(), out habilidade);

        total = ((moeda / taxa) * evento) * habilidade;

        Console.WriteLine("a distancia total foi de : " + Math.Floor(total));

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}