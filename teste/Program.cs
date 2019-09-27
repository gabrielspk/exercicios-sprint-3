using System;

namespace teste
{
     class Program
    {
        static void Main(string[] args)
        {
        Teste aluno1 = new Teste("Alexandre", "123,456,789-00","Prog2");
        Teste aluno2 = new Teste("Cesar","987.654.321-99","Prog1");
            Console.WriteLine("nome: " + aluno1.nome);
            Console.WriteLine("cpf:" + aluno1.cpf);
            Console.WriteLine("curso: " + aluno1.curso);

            Console.WriteLine("nome: " + aluno2.nome);
            Console.WriteLine("cpf: " + aluno2.cpf);
            Console.WriteLine("curso: " + aluno2.curso);
            Console.WriteLine();

            Console.Write("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o cpf: ");
            string cpf = Console.ReadLine();
            Console.Write("Entre com o curso");
            string curso = Console.ReadLine();
            Console.Write("Entre com a nota: ");
            int nota = int.Parse(Console.ReadLine());
            int bimestre = int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());
            Teste aluno3 = new Teste(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nome: " + aluno3.nome);
            Console.WriteLine("cpf: " + aluno3.cpf);
            Console.WriteLine("curso: " + aluno1.curso);
            Console.WriteLine("notas: ");
            foreach(NonSerializedAttribute in aluno3.getNotas()){
                Write(nota + "");
            }

            Console.WriteLine("");
        }
    }
}