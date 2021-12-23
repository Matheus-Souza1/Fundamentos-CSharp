// See https://aka.ms/new-console-template for more information

//Conversão de tipos.

var nota = 10;

// Conversão implicita: Ocorre de forma automatica pois não havera perca de dados durante a conversão, pois ambos são tipos compativeis.
double notaDouble =  nota;

//Conversão explicita: Para realizar essa conversão é preciso fazer um casting dos tipos devido as suas diferenças. onde a frente da variavel se passa entre parênteses o tipo que deseja converter.
int notaInt = (int) notaDouble;


// Conversao utilizando a classe CONVERT

string notaString = "20";

// Basicamente é utilizando a classe Convert passando o metodo(tipo) que deseja, e a variavel como paramentro.
int notaConvert = Convert.ToInt32(notaString);


// Conversao utilizando a classe PARSE

// Se a conversão falhar, retorna uma exceção
int notaParse = int.Parse(notaString);

// Se a conversão falhar, retorna o valor 0
int.TryParse(notaString, out int novaNotaParse);



Console.WriteLine("Bem vindo ao fundamentos de C# - Conversão de tipos!");

Console.WriteLine($"Conversão implicita: {notaDouble}");
Console.WriteLine($"Conversão explicita: {notaInt}");
Console.WriteLine($"Conversão utilizando a classe CONVERT: {notaConvert}");
Console.WriteLine($"Conversao utilizando a classe PARSE: {notaParse}");
Console.WriteLine($"Conversao utilizando a classe TRYPARSE: {novaNotaParse}");

Console.ReadLine();
