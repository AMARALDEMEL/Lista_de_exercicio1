/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("informe o nome do jogador");
        String nome = Console.ReadLine();

        Console.WriteLine("informe a classe do jogador");
        String classe = Console.ReadLine();

        Console.WriteLine("informe a raça do jogador");
        String raça = Console.ReadLine();


        Console.WriteLine("informe a idade do jogador");
        int idade;
        int.TryParse(Console.ReadLine(), out idade);

        Console.WriteLine("informe o nível do jogador");
        int nivel;
        int.TryParse(Console.ReadLine(), out nivel);

        Console.WriteLine("nome: " + nome);
        Console.WriteLine("idade: " + idade);
        Console.WriteLine("nível: " + nivel);
        Console.WriteLine("classe: " + classe);
        Console.WriteLine("raça: " + raça);









    }
}