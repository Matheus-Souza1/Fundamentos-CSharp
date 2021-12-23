// See https://aka.ms/new-console-template for more information

// Utilizando operadores de comparação: >, >=, < , <=
var notaA = 5;
var notaB = 10;

Console.WriteLine("Bem vindo ao fundamentos de C#,operadores de comparação!");

Console.WriteLine("Primeiro Periodo!");
Console.WriteLine($"Otima Nota:{notaA > 10}");
Console.WriteLine($"Nota regular:{notaA > 7}");
Console.WriteLine($"Recuperação:{notaA >=  5}");

Console.Read();

Console.WriteLine("Segundo Periodo!");
Console.WriteLine($"Otima Nota:{notaB <=10 }");
Console.WriteLine($"Nota regular:{ notaB < 10}");
Console.WriteLine($"Recuperação:{ notaB < 5}");

