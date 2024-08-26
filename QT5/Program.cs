/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
•
Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
•
Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois multiplicadores
 (um para condições climáticas e outro para estado do veículo), e calcule a distância total percorrida.
 
@Lista: 01 - Lógica de Programação
@Autor: Lucas Amaral
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {

        double velocidade, tempo, clima, estado, total;

        Console.Write("qual a velocidade do veiculo?: ");
        double.TryParse(Console.ReadLine(), out velocidade);


        Console.Write("qual o tempo d viajem?: ");
        double.TryParse(Console.ReadLine(), out tempo);

        Console.Write("dê um valor para o clima( menor mais chuva): ");
        double.TryParse(Console.ReadLine(), out clima);

        Console.Write("qual o estado do veículo?: ");
        double.TryParse(Console.ReadLine(), out estado);

        total = ((velocidade * tempo) * clima) * estado;

        Console.WriteLine("a distancia total foi de : " + total);

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}