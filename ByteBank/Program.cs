using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("ByteBank - Cadastro de Clientes");
            System.Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool trocouSenha = false;
            do {
                Console.Write ("Senha: ");
                string senha = Console.ReadLine ();
                trocouSenha = cliente1.TrocaSenha (senha);
                if (trocouSenha) {
                    Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    Console.WriteLine ("Senha inválida!");
                }
            } while (!trocouSenha);

            System.Console.WriteLine ("ByteBank - Conta Corrente");
            System.Console.WriteLine ("Titular: ");
            string Titular = Console.ReadLine ();
            System.Console.WriteLine ("Agencia: ");
            int Agencia = Console.ReadLine ();
            System.Console.WriteLine ("Número");
            int Numero = Console.ReadLine ();

           System.Console.WriteLine("Saldo: ");

           

        }
    }
}