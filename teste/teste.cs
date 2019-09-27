using System;

namespace teste
{
    public class Teste{
        //Propriedades
        public string nome{get;set;}
        public string curso{get;set;}
        public string cpf{get;set;}
        public int[] notas;

        //construtor
        public Teste(string nome, string cpf){
            this.nome = nome;
            this.cpf = cpf;
        }
           public Teste(string nome, string cpf, string curso){
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;
        }

        //Metodos de Acesso
        public int[] getNotas(){return notas;}

        public void setNotas(int bi, int nota){
            int i = bi - 1;
            if ((i < 0) || (i > 3)){
                //condição de erro;
                throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1 and 4.");
            }else if (nota < 0 || nota > 10) {
                //Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 10.");
                else
            }
        }
    }
}
