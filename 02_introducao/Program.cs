
// // somente declarando uma variavel do tipo inteira e sem valor 
// int num1;

// // declando uma variavel do tipo inteiro e atribuindo valor 5
// int num2 = 5;

// // declarando uma variavel string
// string nomeAluno = "paulo";

// // uma variavel do tipo logico (true ou false)
// bool resultado = true;

// // variavel do tipo double valor com varias casas decumais 
// double coordenada = 1.2345678653;

// // variavel do tipo decimal - utilizando para valores 
// decimal valor = 1.80M;

int idade = 17;
string meuNome = "Jorge";   //valorPedidoTotal
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");

Console.WriteLine("");
Console.WriteLine("Em qual cidade voçê nasceu?");
// ReadLine serve apenas para que eu receba uma informação do usuario 
// e armazena em uma variavel
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Voçê nasceu em {nomeCidade}");
