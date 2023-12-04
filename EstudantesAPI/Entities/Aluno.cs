using System.ComponentModel.DataAnnotations;

namespace EstudantesAPI.Entities;

public class Aluno
{
    [Key]
    public int? Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Matricula { get; set; }
}
