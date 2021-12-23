// See https://aka.ms/new-console-template for more information

//Utilizando operadores logicos! && (AND), || (OR)

var nota = 8;
bool ultimoPeriodo = true;
bool tccAprovado = true;

Console.WriteLine("Bem vindo ao fundamentos de C#, operadores logicos!");

//Operador || (OR): Nesse operador basta que apenas uma das expressões seja verdadeita para o resultado ser true.

Console.WriteLine($"Aprovado: {nota > 7 || ultimoPeriodo == false }");
Console.WriteLine($"Curso Finalizado: { tccAprovado == false || ultimoPeriodo == false }");
Console.WriteLine($"Fazer o TCC: {tccAprovado == false || ultimoPeriodo == true  }");


Console.Read();

//Operador && (AND): Nesse operador toda as expressões precisam ser verdadeita para o resultado ser true.

Console.WriteLine($"Aprovado: {nota > 7 && ultimoPeriodo == true }");
Console.WriteLine($"Curso Finalizado: {tccAprovado == false && ultimoPeriodo == true }");

