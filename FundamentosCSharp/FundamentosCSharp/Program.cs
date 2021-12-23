// See https://aka.ms/new-console-template for more information

// Tipo de dado usado para representar um texto;
string nome = "Matheus Souza";

// Tipo de dado usado para representar um caractere de texto;
char genero = 'M';

// Tipo de dado usado para representar um numero inteiro;
int idade = 24;

// Tipo de dado usado para representar um valor flutuante: Precisão de 15-16 digitos;
double peso = 95.5;

    // Atribuindo valor maximo a essa variavel
    double valorMaximo = double.MaxValue;

    // Atribuindo valor minimo a essa variavel
    double valorMinimo = double.MinValue;


// Tipo de dado usado para representar um valor flutuante: Precisão de 28-29 digitos;
decimal salario = 3M;

    // Atribuindo valor maximo a essa variavel
    decimal valorMax = decimal.MaxValue;

    // Atribuindo valor minimo a essa variavel
    decimal valorMin = decimal.MinValue;


// Tipo de dado usado para representar um valor verdadeiro ou falso;
bool isTrabalhando = true;

// Tipo de dado usado para representar um valor de data/hora;
DateTime dataAdmissao = new DateTime(2021, 7, 12);



// Varieaveis e Constantes

// VAR é uma maneira implicita para definir tipos de dados ou variaveis. Primeiro é passado a palavra chave(var) é depois se atribui um tipo para essa variavel.
var nomeEmpresa = "Indikatore Suply Chain";

// CONST é uma palavra chave usada para declarar um campo constante, esses valores constantes não podem ser alterados posteriormente.
const int anoFundacao = 2014;


Console.WriteLine("Seja bem vindo ao Fundamentos de C#!");

Console.WriteLine($"Ola eu me chamo {nome} sou do genero {genero} tenho {idade} anos e estou pesando {peso} Kg's." +
    $"É {isTrabalhando} que estou trabalhando atualmente, entrei nesta empresa no dia {dataAdmissao} e ganho um salario de R${salario}K." +
    $"A empresa que eu trabalho se chama {nomeEmpresa} e foi fundada em {anoFundacao} ");
