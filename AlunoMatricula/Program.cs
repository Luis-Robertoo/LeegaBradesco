
using AlunoMatricula;

Console.WriteLine("Busca de alunos");


var alunos = new List<Aluno>
{
    new Aluno { Idade = 42, Matricula = 2458, Nome = "Andre"},
    new Aluno { Idade = 18, Matricula = 456, Nome = "Julia"},
    new Aluno { Idade = 32, Matricula = 198, Nome = "Luis"},
    new Aluno { Idade = 31, Matricula = 42, Nome = "Juliana"},
    new Aluno { Idade = 54, Matricula = 4141, Nome = "Maria"},
    new Aluno { Idade = 22, Matricula = 58, Nome = "Fernanda"}
};

var alunosOrdenados = alunos.OrderBy(aluno => aluno.Matricula).ToList();
foreach (var aluno in alunosOrdenados)
{
    Console.WriteLine(aluno.ToString());
}

Console.WriteLine("Aperte qualquer tecla e ENTER");
Console.ReadLine();
