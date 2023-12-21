using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios.models
{
    public class DominandoOperadores
    {
        public void Operadores()
        {
            string titulo, descricao, dataVencimento;
            // Console.WriteLine("Tarefa:");
            titulo = Console.ReadLine();

            // Console.WriteLine("Descricao:");
            descricao = Console.ReadLine();

            // Console.WriteLine("Data de vencimento:");
            dataVencimento = Console.ReadLine();

            if (descricao.Length > 50)
            {
                Console.WriteLine("Descricao ultrapassa limite de caracteres.");
            }
            else
            {
                 Console.WriteLine($"\n{descricao} ate {dataVencimento}");

            }


        }
    }
}
