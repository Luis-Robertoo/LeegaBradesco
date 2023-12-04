
//2- Utilizando estruturas de repetição e array (vetor), dada uma sequência de n números, imprimi-la na ordem inversa à da leitura.

Console.WriteLine("Sequencia de numeros em ordem inversa");

var numeros = new List<int> { 4, 2, 8, 6, 12, 10, 16, 14 };
var tamanhoArray = numeros.Count();

for (int i = tamanhoArray - 1; i >= 0; i--)
{
    var a = numeros[i];
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("Aperte qualquer tecla e ENTER");
Console.ReadLine();