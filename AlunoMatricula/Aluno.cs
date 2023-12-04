namespace AlunoMatricula;

public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public string ToString()
    {
        return $"Matricula: {Matricula} - Nome: {Nome} - Idade: {Idade}";
    }
}

