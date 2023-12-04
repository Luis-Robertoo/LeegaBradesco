namespace ProcessadorDeArquivos;

public class Venda
{
    public Venda(string regiao, string vendedor, decimal vendeu)
    {
        Regiao = regiao;
        Vendedor = vendedor;
        Vendeu = vendeu;
    }

    public Venda() { }
    public string Regiao { get; set; }
    public string Vendedor { get; set; }
    public decimal Vendeu { get; set; }

    public static implicit operator Venda(string linha)
    {
        var dados = linha.Split(';');
        if (dados.Length != 3) return new Venda();


        var vendedor = dados[0].Trim();
        var regiao = dados[1].Trim();
        var vendeu = Convert.ToDecimal(dados[2].Trim());

        return new Venda(regiao, vendedor, vendeu);
    }

    public string ToString()
    {
        return $"Regiao: {Regiao} - Vendedor: {Vendedor} - Vendeu: {Vendeu}";
    }

}

