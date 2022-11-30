using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            String nome, senha;

            Console.WriteLine("Digite o nome do usuário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a senha do usuário");
            senha = Console.ReadLine();

            if(nome == "Ivan" && senha == "123")
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }




        }
    }
}