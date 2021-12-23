// See https://aka.ms/new-console-template for more information

// Estrutura de condição Switch/Case: Estrutura que atende uma condição a ser executada a partir da expressão escolhida.
// Switch: É a variavel ou valor a ser executado
// Case: É bloco de codigo que sera executado se o valor for igual ao do switch

Console.WriteLine("Bem vindo ao fundamentos de C#, estrutura de condição Switch/Case!");

Console.WriteLine("Digite o opção desejada");

Console.WriteLine("1: Falar no departamento de vendas");
Console.WriteLine("2: Falar no departamento Financeiro");
Console.WriteLine("3: Reclamações");
Console.WriteLine("4: Sair");

var valor = Console.ReadLine();
var valorDigitado = Convert.ToInt32(valor);

switch (valorDigitado)
{
    case 1:

        Console.WriteLine("Bem vindo ao departamento de vendas");

    break;

    case 2:

        Console.WriteLine("Bem vindo ao departamento Financeiro");

    break;

    case 3:

        Console.WriteLine("Nos conte sua reclamação, e sera resolvido o problema");

    break;

    case 4:

        Console.WriteLine("Obrigado por acessar, tenha um bom dia");

    break;

    default:

        Console.WriteLine("Opção digitada invalida!");

    break;
}
