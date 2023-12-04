using EstudantesAPI.Entities;
using EstudantesAPI.Interfaces;

namespace EstudantesAPI.Services;

public class AlunoService : IAlunoService
{
    private readonly IAlunoRepositorie _alunoRepositorie;

    public AlunoService(IAlunoRepositorie alunoRepositorie)
    {
        _alunoRepositorie = alunoRepositorie;
    }

    public async Task<Aluno?> GetAlunoById(int id)
    {
        var aluno = await _alunoRepositorie.Get(id);
        return aluno;
    }

    public async Task<Aluno?> GetAlunoByMatricula(int matricula)
    {
        var aluno = await _alunoRepositorie.GetByMatricula(matricula);
        return aluno;
    }

    public async Task<Aluno?> GetAlunoByName(string nome)
    {
        var aluno = await _alunoRepositorie.GetByNome(nome);
        return aluno;
    }

    public async Task<Aluno?> SaveAluno(Aluno aluno)
    {
        var alunoExists = await _alunoRepositorie.GetByMatricula(aluno.Matricula);
        if (alunoExists != null) return null;

        var alunoSave = await _alunoRepositorie.Create(aluno);
        return alunoSave;
    }

    public async Task<Aluno?> UpdateAluno(int id, Aluno aluno)
    {
        var alunoExists = await _alunoRepositorie.GetByMatricula(aluno.Matricula);
        if (alunoExists is not null && id != alunoExists.Id) return null;

        var alunoUpdate = await _alunoRepositorie.Update(id, aluno);
        return alunoUpdate;
    }
}
