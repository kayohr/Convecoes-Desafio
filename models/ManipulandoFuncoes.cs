using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios.models
{
    public class ManipulandoFuncoes
    {
        public void MaFuncoes()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
        // Horas de uso de eletrônicos por dia e o número de refeições com carne:
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        // Exibe o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // Método para calcular a pegada de carbono com base nos parâmetros fornecidos:
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de emissão específicos para cada atividade
        double fatorTransporte = quilometrosPorDia * 365 * 0.2;
        double fatorEletronicos = horasDeEletronicos * 0.1;
        double fatorCarne = refeicoesComCarne * 0.5;

        // Pegada de carbono total
        double pegadaTotal = fatorTransporte + fatorEletronicos + fatorCarne;

        return pegadaTotal;
    }
    }
}