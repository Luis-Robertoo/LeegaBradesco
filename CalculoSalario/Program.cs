
//1 - Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
//    Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

using CalculoSalario;

try
{
    Console.WriteLine("Cálculo de salário reajustado");

    var listaFuncionarios = new List<Funcionario>
    {
        new Funcionario{ Nome = "Maria", Salario = 504.1m },
        new Funcionario{ Nome = "Jose", Salario = 281 },
        new Funcionario{ Nome = "Guilherme", Salario = 420.2m },
        new Funcionario{ Nome = "Luis", Salario = 810 },
        new Funcionario{ Nome = "Ana", Salario = 69.8m },
        new Funcionario{ Nome = "Caue", Salario = 212.5m },
        new Funcionario{ Nome = "Beatriz", Salario = 747 },
        new Funcionario{ Nome = "Fernanda", Salario = 42m },
        new Funcionario{ Nome = "Laura", Salario = 569.3m },
        new Funcionario{ Nome = "Laika", Salario = 1277 }
    };

    foreach (var funcionario in listaFuncionarios)
    {
        var funcionarioNovoSalario = CalcularAumento(funcionario);
        Console.WriteLine(funcionarioNovoSalario.ToString());
    }
}
catch (Exception e)
{
    Console.WriteLine("Erro ao processar aumento de salarios do funcionarios: {EMessage}", e.Message);
}

Console.WriteLine("Aperte qualquer tecla e ENTER");
Console.ReadLine();

static Funcionario CalcularAumento(Funcionario funcionario)
{
    decimal aumento = 0;
    if (funcionario.Salario <= 300)
    {
        aumento = Porcentagem(50m, funcionario.Salario);
        return new Funcionario { Salario = funcionario.Salario + aumento, Nome = funcionario.Nome };
    }

    aumento = Porcentagem(30m, funcionario.Salario);
    return new Funcionario { Salario = aumento + funcionario.Salario, Nome = funcionario.Nome };
}

static decimal Porcentagem(decimal porcentagem, decimal valor) => (porcentagem / 100 * valor);




