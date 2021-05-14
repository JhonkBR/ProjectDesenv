using System;

namespace Media_GeralPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "#### Media geral dos Alunos ####";
            Console.WriteLine("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Aluno #{i + 1} Nome..: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"Aluno #{i + 1} Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome,provas);

                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }
            Console.Clear();
            double mediaGeral = 0;

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Aluno: {aluno.Media}");
                Console.WriteLine();
                mediaGeral += aluno.Media;
            }
            var resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Média geral dos alunos:{resultadoFinal}");
            Console.ReadKey();
        }
    }
}
