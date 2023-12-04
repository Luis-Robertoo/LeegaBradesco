
using ProcessadorDeArquivos;

Console.WriteLine("Extraindo dados do arquivo");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

var caminho = "C:\\Projetos\\Luis\\CSHARP\\TesteLeegaBradesco\\7-ProcessadorDeArquivos\\extrato de vendas.csv";

if (File.Exists(caminho))
{
    try
    {
        var listaDeVendas = new List<Venda>();
        var listaDeMaioresVendas = new List<Venda>();

        var linhas = File.OpenText(caminho);
        while (!linhas.EndOfStream)
        {
            var linha = linhas.ReadLine();
            if (linha.Contains("Regiao")) continue;

            Venda venda = linha;

            var vendaSalva = listaDeVendas.FirstOrDefault(v => v.Vendedor == venda.Vendedor && v.Regiao == venda.Regiao);

            if (vendaSalva is null)
                listaDeVendas.Add(venda);

            else
                vendaSalva.Vendeu += venda.Vendeu;

            var maiorVendaDaRegiao = listaDeVendas.Where(v => v.Regiao == venda.Regiao).MaxBy(v => v.Vendeu);
            var maiorVendaDaRegiaoSalva = listaDeMaioresVendas.FirstOrDefault(v => v.Regiao == venda.Regiao);

            if (maiorVendaDaRegiaoSalva is null)
            {
                listaDeMaioresVendas.Add(maiorVendaDaRegiao);
                continue;
            }

            if (maiorVendaDaRegiaoSalva.Vendeu > maiorVendaDaRegiao.Vendeu) continue;
            if (maiorVendaDaRegiao.Vendeu > maiorVendaDaRegiaoSalva.Vendeu)
            {
                maiorVendaDaRegiaoSalva.Vendeu = maiorVendaDaRegiao.Vendeu;
                maiorVendaDaRegiaoSalva.Vendedor = maiorVendaDaRegiao.Vendedor;
            }

        }

        foreach (var venda in listaDeMaioresVendas)
        {
            Console.WriteLine(venda.ToString());
        }
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Aperte qualquer tecla e ENTER");
        Console.ReadLine();

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


