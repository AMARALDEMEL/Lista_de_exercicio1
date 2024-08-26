/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
•
Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma batalha.
 Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha,
 o jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual do personagem.
•
Comando: Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido pelo primeiro tipo de inimigo,
 o XP concedido pelo segundo tipo de inimigo, o número de cada tipo de inimigo derrotado, e a constante de nível.
 O programa deve calcular o XP total acumulado após a batalha e determinar o nível atual do jogador.

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

        double xpa, xpi1, xpi2, tipoi1, tipoi2, nivel, total;

        Console.Write("qual a quantidade de xp acumulado?: ");
        double.TryParse(Console.ReadLine(), out xpa);


        Console.Write("qual o XP concedido pelo primeiro tipo de inimigo?: ");
        double.TryParse(Console.ReadLine(), out xpi1);

        Console.Write("quantos inimigos foram derrotados primeiro?: ");
        double.TryParse(Console.ReadLine(), out tipoi1);

        Console.Write("qual o xp concedido pelo segundo tipo de inimigo?: ");
        double.TryParse(Console.ReadLine(), out xpi2);

        Console.Write("qual o número de cada tipo de inimigo derrotado 2?: ");
        double.TryParse(Console.ReadLine(), out tipoi2);


        Console.Write("qual a constante de nivel?: ");
        double.TryParse(Console.ReadLine(), out nivel);

        xpi1 = xpi1 * tipoi1;
        xpi2 = xpi2 * tipoi2;
        xpa = xpi1 + xpi2 + xpa;
        total = xpa/nivel;

        Console.WriteLine("o xp total é de: " + Math.Floor(xpa));
        Console.WriteLine("o nível é de: " + Math.Floor(total));

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}