using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafios.models
{
    public class TiposDeDados
    {
         public void Registros(string[] args)
        {
            // Declare as variáveis para guardar as informações de nome, email e senha:
            string registroEmail, registroNome, registroSenha;

            // Obtém o email, nome e senha do usuário a partir da entrada do console
            Console.WriteLine("Digite o email de registro:");
            registroEmail = Console.ReadLine();

            Console.WriteLine("Digite o nome de registro:");
            registroNome = Console.ReadLine();

            Console.WriteLine("Digite a senha de registro:");
            registroSenha = Console.ReadLine();

            // Imprime a mensagem formatada com o nome do usuário e o email de registro:
            Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");
        }
    }
    }
