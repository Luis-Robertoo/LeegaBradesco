using EstudantesAPI.Entities;

namespace EstudantesAPI.Interfaces;

public interface IAlunoService
{
    Task<Aluno?> GetAlunoById(int id);
    Task<Aluno?> GetAlunoByName(string nome);
    Task<Aluno?> GetAlunoByMatricula(int matricula);
    Task<Aluno?> SaveAluno(Aluno aluno);
    Task<Aluno?> UpdateAluno(int id, Aluno aluno);
}
