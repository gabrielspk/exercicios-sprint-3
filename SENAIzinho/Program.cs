﻿using System;

namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunoCadastrados = 0;
            int salasCadastradas = 0;
            //bool querSair;

        }

        public void CadastrarAluno (Aluno[] alunos, int totalAluno, int alunosCadastrados) {
            if(totalAluno < alunosCadastrados)
            {
                System.Console.WriteLine("Cadastro de Alunos");
                System.Console.WriteLine();
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                System.Console.Write("Dt Nascimento: ");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.DataNascimento = dtNascimento;
                
                int index = 0;
                foreach(Aluno aluno in alunos)
                {
                    if (alunos == null)
                    {
                        alunos[index] = novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrados++;
            }
        }
    }
}
