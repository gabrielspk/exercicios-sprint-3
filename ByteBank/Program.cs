using System;

namespace ByteBank {
    class Program {

        #region Clientes

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
            #endregion

            #region Conta

            System.Console.WriteLine ("ByteBank - Cadastro da conta");

            System.Console.WriteLine ("Entre com a agência: ");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Entre com a conta: ");
            int conta = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Entre com o número do titular: ");
            string titular = Console.ReadLine ();

            ContaCorrente contaCorrente1 = new ContaCorrente (titular, agencia, cliente1);
            double saldo;
            do {
                Console.Write ("Entre com o saldo");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    contaCorrente1.Saldo = saldo;
                } else {
                    Console.WriteLine ("Valor do saldo deve ser positivo");
                }
            } while (saldo < 0);
            Console.WriteLine ();
            #endregion

        Cliente cliente2 = new Cliente("Cesar","123.123.123-12","1@a.com");
        ContaCorrente contaCorrente2 = new ContaCorrente("123","321",cliente2);

        #region Depósito
            
        System.Console.WriteLine("ByteBank - Depósito em Conta");
        System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
        System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta");
        System.Console.WriteLine($"Saldo {contaCorrente1.Saldo}");
        Console.WriteLine();
        Console.Write("Digite o valor do Depósito: ");
        double valor = double.Parse(Console.ReadLine());
        contaCorrente1.Deposito(valor);
        Console.WriteLine();
        Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
        Console.WriteLine();
        #endregion

        #region Saque
        System.Console.WriteLine("ByteBank - Saque");
        System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            
        #endregion

        
        }

    }
}