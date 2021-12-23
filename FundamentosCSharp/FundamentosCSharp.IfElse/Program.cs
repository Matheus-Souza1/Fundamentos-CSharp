// See https://aka.ms/new-console-template for more information

// Estrutura de condição If/Else: Estrutura que atende uma condição e a partir dela o programa consegue tomar um tipo de decisão especifica.
// If ou else if: É executado quando o bloco de codigo é verdadeiro
// Else: É executado quando o bloco de codigo é falso

Console.WriteLine("Bem vindo ao fundamentos de C#, Estrutura condicional If/Else!");

Console.WriteLine("Digite a nota do Aluno!");

var nota = Console.ReadLine();
var notaAluno = Convert.ToInt32(nota);

if (notaAluno >= 7)
{
    Console.WriteLine($"Parabens você tirou {notaAluno} pontos, e esta aprovado!");

} else if (notaAluno >= 5)
{
    Console.WriteLine($"Devido aos {notaAluno} pontos, você precisara fazer a recuperação!");
} else
{
    Console.WriteLine($"Infelizmente os {notaAluno} pontos não foram suficiente, então esta reprovado!");
}


