// See https://aka.ms/new-console-template for more information
using MetodoDeExtensao;

Console.WriteLine("Conversor de formato de data");


var data = DateTime.Now;
Console.WriteLine($"Formato original: {data}");

Console.WriteLine($"Formato convertido: {data.DateToInt()}");

Console.WriteLine("Aperte qualquer tecla e ENTER");
Console.ReadLine();