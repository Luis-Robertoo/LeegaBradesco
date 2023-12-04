using EstudantesAPI.Entities;
using EstudantesAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EstudantesAPI.Repositories;

public class AlunoRepositorie : IAlunoRepositorie
{
    private readonly DataBaseContext _context;

    public AlunoRepositorie(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<Aluno?> Create(Aluno aluno)
    {
        var alunoSaved = await _context.Aluno.AddAsync(aluno);
        var totalSaves = await _context.SaveChangesAsync();
        if (totalSaves < 1) return null;
        return alunoSaved.Entity;
    }

    public async Task<Aluno?> GetByMatricula(int matricula)
    {
        var aluno = await _context.Aluno.FirstOrDefaultAsync(a => a.Matricula.Equals(matricula));
        return aluno;
    }

    public async Task<Aluno?> GetByNome(string nome)
    {
        var aluno = await _context.Aluno.FirstOrDefaultAsync(a => a.Nome.Contains(nome));
        return aluno;
    }

    public async Task<Aluno?> Get(int id)
    {
        var aluno = await _context.Aluno.FirstOrDefaultAsync(a => a.Id == id);
        return aluno;
    }

    public async Task<Aluno?> Update(int id, Aluno aluno)
    {

        var AlunoSave = await Get(id);
        if (AlunoSave is null) return null;

        aluno.Id = id;
        _context.Entry(AlunoSave).CurrentValues.SetValues(aluno);
        var totalSaves = await _context.SaveChangesAsync();
        if (totalSaves < 1) return null;

        return await Get(id);
    }
}
