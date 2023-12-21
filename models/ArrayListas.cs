using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios.models
{
    public class ArrayEListas
    {
        
    public void ArrayListas()
    {
         int quantidadeJogos = int.Parse(Console.ReadLine());

        // Inicializa o array de nomes de jogos com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos];

        // Loop para adicionar jogos conforme a quantidade especificada:
        for (int i = 0; i < quantidadeJogos; i++)
        {
            // Chama a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
            AdicionarJogo(i, nomesJogos);
        }

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        //Console.WriteLine($"Digite o nome do jogo {indice + 1}:");
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        // Exibe o resumo
        Console.Write($"Foi adicionado '{quantidadeJogos}' jogos: ");
        
        // Adiciona os nomes dos jogos separados por vírgula
        Console.Write(string.Join(", ", nomes));
        
        Console.WriteLine(" ao catalogo.");
    }
}
}