/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
•
Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser distribuídos entre força, agilidade,
 inteligência e dois atributos adicionais.
•
Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade atribuídos a cada uma das cinco características
 e calcule o total de pontos distribuídos.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {

        int f, a, i, d, v, total;

        Console.Write("qual o número 1?: ");
        int.TryParse(Console.ReadLine(), out f);


        Console.Write("qual o número 2?: ");
        int.TryParse(Console.ReadLine(), out a);

        Console.Write("qual o número 3?: ");
        int.TryParse(Console.ReadLine(), out i);

        Console.Write("qual o número 4?: ");
        int.TryParse(Console.ReadLine(), out d);

        Console.Write("qual o número 5?: ");
        int.TryParse(Console.ReadLine(), out v);

        total = (f + a + i + d + v);

        Console.WriteLine("o nível é de: " + (total));

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}