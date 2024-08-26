/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Quanto você tem de vida: ");
        int vida;
        int.TryParse(Console.ReadLine(), out vida);

        Console.Write("Quanto de dano você recebeu: ");
        int dano;
        int.TryParse(Console.ReadLine(), out dano);

        Console.Write("Qual seu bonus de regenração: ");
        int regenraçao;
        int.TryParse(Console.ReadLine(), out regenraçao);

        Console.Write("Qual o valor do seu item modificador: ");
        double itens;
        double.TryParse(Console.ReadLine(),out itens);

        Console.Write("Qual valor da sua habilidade: ");
        double hab;
        double.TryParse(Console.ReadLine(),out hab);

        double vidaF = ((vida - dano * itens) + regenraçao * hab);

        Console.Write("Sua vida é de: " + vidaF);

        Console.ReadLine();
    }
}