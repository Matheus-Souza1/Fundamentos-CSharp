// See https://aka.ms/new-console-template for more information

// Utilizando operadores Aritmeticos

// Utilizando operadores de incremento e decremento

int numero = 1;

Console.WriteLine("Bem vindo ao fundamentos de c#, operadores Aritmeticos!");

// Primeiro ira executar essa linha, depois ira incrementar o valor;
Console.WriteLine($"Incremento apos a execução: {numero++}"); //1

// Primeiro ira executar essa linha, depois ira decrementar o valor;
Console.WriteLine($"Decremento apos a execução:{numero--}"); // 2

// Primeiro ira incrementar o valor, depois ira executar essa linha;
Console.WriteLine($"Incremento antes da execução:{++numero}"); //2

//Primeiro ira decrementar o valor, depois ira executar essa linha;
Console.WriteLine($"Decremento antes da execução:{--numero}"); //1



// Utilizando operadores para calculos aritmeticos

var soma = 4 + 4;
var subtracao = 4 - 4;
var multiplicacao = 4 * 4;
var divisao = 4 / 4;
var divisaoDouble = (double) 4 / 3;  // Ira mostrar as casas decimais. 

Console.WriteLine($"Valor da soma: {soma}");
Console.WriteLine($"Valor da subtração: {subtracao}");
Console.WriteLine($"Valor da multiplicação: {multiplicacao}");
Console.WriteLine($"Valor da divisão: {divisao}");
Console.WriteLine($"Valor da divisão com valores decimais: {divisaoDouble}");


