using EstudantesAPI.Entities;

namespace EstudantesAPI.Interfaces;

public interface IAlunoRepositorie
{
    Task<Aluno?> Get(int id);
    Task<Aluno?> GetByMatricula(int matricula);
    Task<Aluno?> GetByNome(string nome);
    Task<Aluno?> Create(Aluno aluno);
    Task<Aluno?> Update(int id, Aluno aluno);
}
