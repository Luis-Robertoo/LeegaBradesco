using EstudantesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstudantesAPI.Repositories;

public class DataBaseContext : DbContext
{

    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "AlunosSalvos");
    }

    public DbSet<Aluno> Aluno { get; set; }
}
