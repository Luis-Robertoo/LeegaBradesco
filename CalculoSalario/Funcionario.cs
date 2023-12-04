namespace CalculoSalario;

public class Funcionario
{
    public string Nome { get; set; }
    public decimal Salario { get; set; }

    public string ToString()
    {
        return $"Funcionario: {this.Nome} - Salario: {this.Salario}";
    }
}
