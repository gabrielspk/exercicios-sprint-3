namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;

        

        public Sala (int capacidadeAtual, int capacidadeTotal)
        {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.Alunos = new string [capacidadeTotal];
        }

        public string AlocarAluno (string NomeAluno)
        {
            this.NomeAluno = NomeAluno;

            Alunos[capacidadeTotal - 1] = NomeAluno;

            capacidadeTotal = capacidadeTotal - 1;
        }

    
        
        public string RemoverAluno (string Alunos)
        {
            this.NomeAluno = NomeALuno;
            System.Console.WriteLine("Digite o nome do Aluno: ");
            


        }

        public String MostrarAlunos (string Alunos)
        
    }
}